using connectDB2.Properties;
using Dapper;
using MySql.Data.MySqlClient;

namespace connectDB2
{
    internal class DBrequest
    {

        MySqlConnection ConectDB;

        public DBrequest()
        {
            //Connection strin stored in properties:
            ConectDB = new(Settings.Default.stringConnect);
        }
        public void OpenConnection()
        {
            ConectDB.Open();
        }

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
        public int InsertUser(string nom, string prenom, DateTime dtNaiss)
        {
            try
            {
                ConectDB.Open();
                //New user u created:
                User u = new();
                //Assigning attribute name value to function argument.
                u.Nom = nom;
                //Tequest stored.
                var request = "insert into utilisateurs(nom, prenom, dtNaiss) values (@nom,@prenom,@dtNaiss);";
                //This Execute method wil return the number of created items.
                return ConectDB.Execute(request, new { nom, prenom, dtNaiss });
            }
            finally
            {
                ConectDB.Close();
            }
        }
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

        public int UpdateUser(int id, string NewName, string NewPrenom, DateTime NewDtNaiss)
        {
            try
            {

                ConectDB.Open();
                //Condition qui vérifie que les valeurs dans la table correspondent à celles en BDD:

                string request = "UPDATE utilisateurs SET Nom = @NewName, Prenom = @NewPrenom, DtNaiss=@NewDtNaiss WHERE Id=@id;";
                //if (Current.Nom = NewName, Prenom = @NewPrenom && DtNaiss = @NewDtNaiss){
                var deletedRows = ConectDB.Execute(request, new { id, NewName, NewPrenom, NewDtNaiss });
                return deletedRows;

            }
            finally
            {
                ConectDB.Close();
            }

        }

    }
}
