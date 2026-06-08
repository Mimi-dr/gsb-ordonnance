using MySql.Data.MySqlClient;

namespace GSB_Ordonnance
{
    public static class Database
    {
        private const string CHAINE_CONNEXION =
            "Server=localhost;" +
            "Port=3306;" +
            "Database=gsb_ordonnances;" +
            "Uid=gsb;" +
            "Pwd=gsbpass;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(CHAINE_CONNEXION);
            conn.Open();
            return conn;
        }
    }
}
