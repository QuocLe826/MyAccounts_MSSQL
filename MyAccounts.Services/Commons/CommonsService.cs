using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAccounts.Libraries.Helpers;
using MyAccounts.Services.BaseServices;

namespace MyAccounts.Services.Commons
{
    public class CommonsService: BaseService
    {
        public CommonsService(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string InsertUserInfo(string firstName, string lastName, string userName, string password)
        {
            try
            {
                var query = "Users_CreateNewUser";
                var res = ExecuteDataTable(query, CommandType.StoredProcedure,
                    new SqlParameter("@firstName", firstName),
                    new SqlParameter("@lastName", lastName),
                    new SqlParameter("@userName", userName),
                    new SqlParameter("@password", password));
                if (res.Rows.Count <= 0)
                {
                    return "Create new user failed!";
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string BackupDatabase(string path)
        {
            try
            {
                var query = string.Format(@"BACKUP DATABASE MYACCOUNTS TO DISK = '{0}'", path);
                var res = ExecuteNonQuery(query);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string RestoreDatabase(string path)
        {
            try
            {
                var query = string.Format(@"RESTORE DATABASE MYACCOUNTS FROM DISK = '{0}'
                                            IF EXISTS(SELECT 1 FROM SYS.DATABASES WHERE NAME = 'MYACCOUNTS')
                                            BEGIN
	                                            SELECT 1
                                            END", path);
                var dt = ExecuteDataTable(query);
                if (dt.Rows.Count > 0 && Functions.ParseInteger(dt.Rows[0][0]) == 1)
                {
                    return "";
                }
                return "Initialized system failed!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
