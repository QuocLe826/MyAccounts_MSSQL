using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAccounts.Libraries.Security;
using MyAccounts.Services.Commons;

namespace MyAccounts.Api
{
    public class BaseController
    {
        private const string CONFIG_FILE = "Config.json";
        private const string DATABASE = "MYACCOUNTS";
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

            switch (authType)
            {
                case "WindowsAuth":
                    ConnectionString = string.Format(@"Data Source={0}; Initial Catalog={1}; Integrated Security=True", serverName, DATABASE);
                    break;
                case "ServerAuth":
                    ConnectionString = string.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2};Password={3}", serverName, DATABASE, serverUser, serverPwd);
                    break;
            }
        }
    }
}
