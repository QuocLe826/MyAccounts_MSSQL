using System;
using System.Data;
using System.Data.SqlClient;
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

        public Tuple<string, string> InsertUserInfo(string firstName, string lastName, string userName, string password)
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
                    return new Tuple<string, string>("Create new user failed!", "Tạo người dùng thất bại!");
                }
                return new Tuple<string, string>("", "");
            }
            catch (Exception ex)
            {
                return new Tuple<string, string>("", "");
            }
        }

        public Tuple<string, string> BackupDatabase(string path)
        {
            try
            {
                var query = string.Format(@"BACKUP DATABASE MYACCOUNTS TO DISK = '{0}'", path);
                var res = ExecuteNonQuery(query);
                return new Tuple<string, string>("", "");
            }
            catch (Exception ex)
            {
                return new Tuple<string, string>(ex.Message, ex.Message);
            }
        }

        public Tuple<string, string> RestoreDatabase(string path)
        {
            try
            {
                var query = string.Format(@"IF EXISTS(SELECT 1 FROM sys.DATABASES where name = 'MYACCOUNTS')
                                            BEGIN
                                                USE master
                                                DROP DATABASE MYACCOUNTS
                                            END
                                            RESTORE DATABASE MYACCOUNTS FROM DISK = '{0}'
                                            IF EXISTS(SELECT 1 FROM SYS.DATABASES WHERE NAME = 'MYACCOUNTS')
                                            BEGIN
	                                            SELECT 1
                                            END", path);
                var dt = ExecuteDataTable(query);
                if (dt.Rows.Count > 0 && Functions.ParseInteger(dt.Rows[0][0]) == 1)
                {
                    return new Tuple<string, string>("", "");
                }
                return new Tuple<string, string>("Restore system failed!", "Khôi phục hệ thống thất bại!");
            }
            catch (Exception ex)
            {
                return new Tuple<string, string>(ex.Message, ex.Message);
            }
        }
    }
}
