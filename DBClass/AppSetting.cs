using System.Configuration;


namespace DBClass
{
    public class AppSetting
    {
        private readonly Configuration config;

        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public void SetConnectionString(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.OleDb";
            config.Save(ConfigurationSaveMode.Modified);
        }

        public string[] GetParametrConnectionString(string connection)
        {
            string[] s = connection.Split(new char[] { ';', '=' });
            return s;

        }

        public string GetConnectionString()
        {
            string connStr = GetConnectionString("DBClass.Properties.Settings.dbs_ConnectString");
            string[] s = GetParametrConnectionString(connStr);
            return s[3];
        }


    }
}
