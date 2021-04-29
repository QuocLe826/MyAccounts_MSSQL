using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAccounts.Services.BaseServices;

namespace MyAccounts.Services.Commons
{
    public class CommonsService: BaseService
    {
        public CommonsService(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string InitDatabase()
        {
            try
            {
                var query = @"if not exists(select 1 from sys.databases where name = 'MYACCOUNTS')
                            begin
                                create database MYACCOUNTS
                            end";
                var res = ExecuteNonQuery(query);
                if (res == -1)
                {
                    return "";
                }

                return "Cannot create database";
            }
            catch (Exception ex)
            {
                return "Cannot create database\\r\\nError: " + ex.Message;
            }
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
                var query = string.Format(@"RESTORE DATABASE MYACCOUNTS FROM DISK = '{0}'", path);
                var res = ExecuteNonQuery(query);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
