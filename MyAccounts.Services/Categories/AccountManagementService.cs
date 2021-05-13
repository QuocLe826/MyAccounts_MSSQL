using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MyAccounts.Libraries.Helpers;
using MyAccounts.Libraries.Security;
using MyAccounts.Services.BaseServices;

namespace MyAccounts.Services.Categories
{
    public class AccountManagementService: BaseService
    {
        public AccountManagementService(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public DataTable GetAccountGroups()
        {
            try
            {
                var query = "AccountManagement_GetAccountGroups";
                var dt = ExecuteDataTable(query, CommandType.StoredProcedure);
                return dt;
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public DataTable GetAccountType()
        {
            try
            {
                var query = "AccountManagement_GetAccountType";
                var dt = ExecuteDataTable(query, CommandType.StoredProcedure);
                return dt;
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }


        public DataTable GetAccountManagement()
        {
            try
            {
                var query = "AccountManagement_GetData";
                var dt = ExecuteDataTable(query, CommandType.StoredProcedure);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        row["Username"] = RSASecurity.Decrypt(Functions.ToString(row["Username"]) + "=");
                        row["Password"] = RSASecurity.Decrypt(Functions.ToString(row["Password"]) + "=");
                    }
                    dt.AcceptChanges();
                }
                return dt;
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public DataTable GetAccountManagementByCode(string code)
        {
            try
            {
                var query = "AccountManagement_GetDataByCode";
                var dt = ExecuteDataTable(query, CommandType.StoredProcedure, new SqlParameter("@code", code));
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        row["Username"] = RSASecurity.Decrypt(Functions.ToString(row["Username"]) + "=");
                        row["Password"] = RSASecurity.Decrypt(Functions.ToString(row["Password"]) + "=");
                    }
                    dt.AcceptChanges();
                }
                return dt;
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public DataTable SearchData(string username, string accGroup, string accType)
        {
            try
            {
                var query = "AccountManagement_SearchData";
                var dt = ExecuteDataTable(query, CommandType.StoredProcedure, new SqlParameter("@username", username),
                    new SqlParameter("@accGroup", accGroup), new SqlParameter("@accType", accType));
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        row["Username"] = RSASecurity.Decrypt(Functions.ToString(row["Username"]) + "=");
                        row["Password"] = RSASecurity.Decrypt(Functions.ToString(row["Password"]) + "=");
                    }
                    dt.AcceptChanges();
                }
                return dt;
            }
            catch (Exception e)
            {
                return new DataTable();
            }
        }

        public string ProcessData(Dictionary<string,string> dicData, string actionType)
        {
            try
            {
                var userEncrypt = RSASecurity.Encrypt(dicData["Username"]);
                var pwdEncrypt = RSASecurity.Encrypt(dicData["Password"]);
                dicData["Username"] = userEncrypt.Substring(0, userEncrypt.Length - 1);
                dicData["Password"] = pwdEncrypt.Substring(0, pwdEncrypt.Length - 1);

                var query = "AccountManagement_ProcessData";
                var result = ExecuteDataTable(query, CommandType.StoredProcedure,
                    new SqlParameter("@code", dicData["Code"]),
                    new SqlParameter("@name", dicData["Name"]),
                    new SqlParameter("@username", dicData["Username"]),
                    new SqlParameter("@password", dicData["Password"]),
                    new SqlParameter("@accGroup", dicData["AccGroup"]),
                    new SqlParameter("@accType", dicData["AccType"]),
                    new SqlParameter("@status", dicData["Status"]),
                    new SqlParameter("@descriptions", dicData["Descriptions"]),
                    new SqlParameter("@actionType", actionType));

                if (result.Rows.Count > 0)
                {
                    return "";
                }
                return "Save failed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteAccount(string code)
        {
            try
            {
                var query = "AccountManagement_DeleteAccount";
                var result = ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@code", code));
                if (result > 0)
                {
                    return "";
                }
                return "Delete failed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
