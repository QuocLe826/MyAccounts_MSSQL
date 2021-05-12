using System.Collections.Generic;

namespace MyAccounts.Libraries.Constants
{
    public class CommonConstants
    {
        public static Dictionary<string, string> DicDatabaseProvider = new Dictionary<string, string>()
        {
            { "MSSQL", "Microsoft SQL Server" }
        };

        public static Dictionary<string, string> DicAuthentications = new Dictionary<string, string>()
        {
            { "WindowsAuth", "Windows Authentication" },
            { "ServerAuth", "Server Authentication"}
        };

        public static Dictionary<string, string> DicStatus_EN = new Dictionary<string, string>()
        {
            { "Y", "Active" },
            { "N", "Inactive"}
        };

        public static Dictionary<string, string> DicStatus_VN = new Dictionary<string, string>()
        {
            { "Y", "Hoạt động" },
            { "N", "Không hoạt động"}
        };
    }
}
