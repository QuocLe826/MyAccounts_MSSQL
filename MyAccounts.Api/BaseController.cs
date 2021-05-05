using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using MyAccounts.Libraries.Security;

namespace MyAccounts.Api
{
    public class BaseController
    {
        private const string CONFIG_FILE = "System//config//serverconfig.json";
        public string ConnectionString { get; set; }

        public BaseController()
        {
            ReadConfigurations();
        }

        private void ReadConfigurations()
        {
            if(!File.Exists(CONFIG_FILE))
            {
                return;
            }

            var fileData = File.ReadAllText(CONFIG_FILE);
            if(string.IsNullOrEmpty(fileData))
            {
                return;
            }
            var dicData = JsonConvert.DeserializeObject<Dictionary<string, string>>(fileData);
            if(dicData.Count == 0)
            {
                return;
            }

            var authType = RSASecurity.Decrypt(dicData["Authentication"]);
            var serverName = RSASecurity.Decrypt(dicData["ServerName"]);
            var serverUser = RSASecurity.Decrypt(dicData["ServerUser"]);
            var serverPwd = RSASecurity.Decrypt(dicData["ServerPassword"]);
            var databaseName = RSASecurity.Decrypt(dicData["DatabaseName"]);

            switch (authType)
            {
                case "WindowsAuth":
                    ConnectionString = string.Format(@"Data Source={0}; Initial Catalog={1}; Integrated Security=True", serverName, databaseName);
                    break;
                case "ServerAuth":
                    ConnectionString = string.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2};Password={3}", serverName, databaseName, serverUser, serverPwd);
                    break;
            }
        }
    }
}
