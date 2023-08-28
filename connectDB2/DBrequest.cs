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
            ConectDB = new(Settings.Default.stringConnect);
        }
        public void OpenConnection()
        {
            ConectDB.Open();
        }

        public IEnumerable<User> GetUsers()
        {
            ConectDB.Open();
            String request = "select * from utilisateurs";
            var users = ConectDB.Query<User>(request);
            ConectDB.Close();
            return users;
        }
        public int InsertUser(string nom, string prenom, DateTime dtNaiss)
        {
            try
            {
                ConectDB.Open();
                User u = new();
                u.Nom = nom;
                var request = "insert into utilisateurs(nom, prenom, dtNaiss) values (@nom,@prenom,@dtNaiss);";
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

                string request = "DELETE FROM  utilisateurs WHERE @Id = @id;";
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

                string request = "UPDATE utilisateurs SET Nom = @NewName, Prenom = @NewPrenom, DtNaiss=@NewDtNaiss WHERE Id=@id;";
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
