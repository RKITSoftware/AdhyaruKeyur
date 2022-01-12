namespace CountriesAPI.Database
{
    public class DBConfig
    {
        #region Public Members

        public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString;

        #endregion Public Members
    }
}