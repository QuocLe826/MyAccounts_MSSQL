using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAccounts.Libraries.Helpers;
using MyAccounts.Services.BaseServices;

namespace MyAccounts.Services.Categories
{
    public class AccountGroupsService: BaseService
    {
        public AccountGroupsService(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public DataTable GetAccountGroups()
        {
            try
            {
                var query = "AccountGroups_GetData";
                return ExecuteDataTable(query, CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public DataTable SearchAccountGroup(string code, string name, string status, string descriptions)
        {
            try
            {
                var query = "AccountGroups_SearchData";
                return ExecuteDataTable(query, CommandType.StoredProcedure,
                    new SqlParameter("@code", code),
                    new SqlParameter("@name", name),
                    new SqlParameter("@status", status),
                    new SqlParameter("@descriptions", descriptions));
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public string ProcessAccountGroups(DataTable dt, string actionType)
        {
            try
            {
                var query = "AccountGroups_ProcessData";
                var dtResult = ExecuteDataTable(query, CommandType.StoredProcedure,
                    new SqlParameter("@code", Functions.ToString(dt.Rows[0]["Code"])),
                    new SqlParameter("@name", Functions.ToString(dt.Rows[0]["Name"])),
                    new SqlParameter("@status", Functions.ToString(dt.Rows[0]["Status"])),
                    new SqlParameter("@descriptions", Functions.ToString(dt.Rows[0]["Descriptions"])),
                    new SqlParameter("actionType", actionType));
                if (dtResult.Rows.Count > 0)
                {
                    return "";
                }
                return "Save failed!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteAccountGroups(string code)
        {
            try
            {
                var query = "AccountGroups_DeleteData";
                var res = ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@code", code));
                if (res > 0)
                {
                    return "";
                }
                return "Delete failed!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
