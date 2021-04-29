using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounts.Libraries.Enums
{
    public class Enums
    {
        /// <summary>
        /// Enum xác định Message Box Type
        /// </summary>
        public enum MessageBoxType
        {
            Information = 1,
            Error = 2,
            Warnings = 3,
            Question = 4,
            Retry = 5
        }

        /// <summary>
        /// Enum database system type
        /// </summary>
        public enum DatabaseSystemType
        {
            NoProvider = -1,
            MSSQL = 1
        }

        /// <summary>
        /// Enum Authentication type
        /// </summary>
        public enum AuthenticationType
        {
            WindowsAuthentication = 1,
            SQLServerAuthentication = 2
        }
    }
}
