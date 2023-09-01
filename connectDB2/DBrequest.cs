using connectDB2.Properties;
using Dapper;
using MySql.Data.MySqlClient;

namespace connectDB2
{
    //This class is dedicated to the application's various database queries.
    internal class DBrequest
    {

        //This sqlConnection object ConectDB déclared as a global variable   variable is used to establish or close the connection to the database.
        MySqlConnection ConectDB;

        public DBrequest()
        {
            //Connection string stored in properties:
            ConectDB = new(Settings.Default.stringConnect);
        }

        //Function to read the list of users.
        public IEnumerable<User> GetUsers()
        {//Oprning the connection:
            ConectDB.Open();
            String request = "select * from utilisateurs";
            //List of all the users retrived during the query:
            var users = ConectDB.Query<User>(request);
            //Closing the connection:
            ConectDB.Close();
            return users;
        }
        //Function to create a new user.
        public int InsertUser(string nom, string prenom, DateTime? dtNaiss)
        {//Ternaire pour doner null à la date si le datetimepicker est coché:
            //User(TxtNom.text, TxtPrenom.txt, dtpDtNaiss.Checked ? dtpDtNaiss.Value : null);
            try
            {
                ConectDB.Open();

                //Query to avoid errors linked to duplicate insertions.
                var Request = "INSERT ignore INTO utilisateurs (Nom,Prenom,DtNaiss) VALUES (@nom, @prenom, @dtNaiss); SELECT LAST_INSERT_ID()";
                var result = ConectDB.Query<int>(Request, new { nom, prenom, dtNaiss });
                MessageBox.Show("l'utilisateur " + nom + " " + " " + prenom + " à bien été créé.");
                return result.Single();
            }
            finally { ConectDB.Close(); }
        }
        //Function to delete the selected user.
        public int DeleteUser(int id)
        {
            try
            {
                ConectDB.Open();

                string request = "DELETE FROM  utilisateurs WHERE Id = @id;";
                //This Execue method wil return the number of deleted items.
                var deletedRows = ConectDB.Execute(request, new { id });
                return deletedRows;
            }
            finally
            {
                ConectDB.Close();
            }
        }



        //Function to update the selected user.
        public int UpdateUser(int id, string nom, string prenom, DateTime? dtNaiss, string currentNom, string currentPrenom, DateTime? currentDtNaiss)
        {
            try
            {

                ////Open connection.
                ConectDB.Open();

                // optimistic update query.
                string query = "UPDATE utilisateurs SET Nom = @Nom, Prenom=@Prenom, DtNaiss=@DtNaiss WHERE  Nom = @currentNom AND Prenom=@currentPrenom AND(dtNaiss is null AND DtNaiss=@currentDtNaiss;";

                // Execute the query.
                int updated = ConectDB.Execute(query, new { id, nom, prenom, dtNaiss, currentNom, currentPrenom, currentDtNaiss });

                // Check if the update was successful.
                if (updated == 0)
                {
                    throw new Exception("La mise à jour de l'utilisateur a échoué.");

                }

                // Display a message to the user.
                MessageBox.Show("L'utilisateur " + nom + " " + " " + prenom + " a bien été mis à jour.");

                return updated;
            }
            finally
            {

                //Closing the connection even if the SQL query fails.
                ConectDB.Close();
            }
        }
        public int UpdateOptimistUtilisateur(int id, string nom, string prenom, DateTime? dtNaiss, string oldNom, string oldPrenom, DateTime? oldDtNaiss)
        {
            try
            {
                ConectDB.Open();
                var q = "UPDATE Utilisateurs SET Nom = @nom, Prenom = @prenom, DtNaiss = @dtNaiss WHERE Id = @id and Nom = @oldNom and Prenom = @oldPrenom and ((DtNaiss is NULL and @oldDtNaiss is null) or DtNaiss = @oldDtNaiss)";
                var result = ConectDB.Execute(q, new { id, nom, prenom, dtNaiss, oldNom, oldPrenom, oldDtNaiss });
                return result;
            }
            finally { ConectDB.Close(); }
        }


    }
}

