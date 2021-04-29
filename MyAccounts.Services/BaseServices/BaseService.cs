using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace MyAccounts.Services.BaseServices
{
    public class BaseService
    {
        public string ConnectionString { get; set; }

        public SqlConnection DbConnection { get; set; }

        public SqlTransaction DbTransaction { get; set; }


        public BaseService()
        {
        }

        public SqlConnection OpenConnection()
        {
            DbConnection = DbConnection == null || string.IsNullOrEmpty(DbConnection.ConnectionString) ? new SqlConnection(ConnectionString) : DbConnection;
            if(DbConnection.State == ConnectionState.Closed || DbConnection.State == ConnectionState.Broken)
            {
                DbConnection.Open();
            }
            return DbConnection;
        }

        /// <summary>
        /// Kiểm tra kết nối đến SQL Server
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="initialCatalog"></param
        /// <returns></returns>
        public bool CheckConnection(string serverName, string database)
        {
            try
            {
                var connectionString = string.Format(@"Data Source={0}; Initial Catalog={1}; Integrated Security=True", serverName.Trim(), database.Trim());
                var dbConnection = new SqlConnection(connectionString);
                if (dbConnection.State == ConnectionState.Closed || dbConnection.State == ConnectionState.Broken)
                {
                    dbConnection.Open();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra kết nối đến SQL Server
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="initialCatalog"></param
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckConnection(string serverName, string database, string username, string password)
        {
            try
            {
                var connectionString = string.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2};Password={3}; Integrated Security=True",
                    serverName.Trim(), database.Trim(), username.Trim(), password.Trim());
                var dbConnection = new SqlConnection(connectionString);
                if (dbConnection.State == ConnectionState.Closed || dbConnection.State == ConnectionState.Broken)
                {
                    dbConnection.Open();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra kết nối đến SQL Server
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public bool CheckConnection(string connectionString)
        {
            try
            {
                var dbConnection = new SqlConnection(connectionString);
                if (dbConnection.State == ConnectionState.Closed || dbConnection.State == ConnectionState.Broken)
                {
                    dbConnection.Open();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int ExecuteNonQuery(string query, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            if (DbConnection != null && !string.IsNullOrEmpty(DbConnection.ConnectionString) && DbConnection.State != ConnectionState.Closed)
            {
                using (var command = DbConnection.CreateCommand())
                {
                    command.CommandTimeout = 60000;
                    command.CommandText = query;
                    command.Transaction = DbTransaction;
                    command.CommandType = commandType;
                    command.Parameters.AddRange(parameters);
                    return command.ExecuteNonQuery();
                }
            }
            using (var conn = new SqlConnection(ConnectionString))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                var command = conn.CreateCommand();
                command.CommandTimeout = 60000;
                command.CommandText = query;
                command.CommandType = commandType;
                command.Parameters.AddRange(parameters);
                return command.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string query, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            if (DbConnection != null && !string.IsNullOrEmpty(DbConnection.ConnectionString) && DbConnection.State != ConnectionState.Closed)
            {
                using (var command = DbConnection.CreateCommand())
                {
                    command.CommandTimeout = 60000;
                    command.CommandText = query;
                    command.Transaction = DbTransaction;
                    command.CommandType = commandType;
                    command.Parameters.AddRange(parameters);
                    return command.ExecuteScalar();
                }
            }
            using (var conn = new SqlConnection(ConnectionString))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                var command = conn.CreateCommand();
                command.CommandTimeout = 60000;
                command.CommandText = query;
                command.CommandType = commandType;
                command.Parameters.AddRange(parameters);
                return command.ExecuteScalar();
            }
        }

        public DataSet ExecuteData(string query, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            var dtSet = new DataSet();
            if (DbConnection != null && !string.IsNullOrEmpty(DbConnection.ConnectionString) && DbConnection.State != ConnectionState.Closed)
            {
                using (SqlCommand command = DbConnection.CreateCommand())
                {
                    command.CommandTimeout = 60000;
                    command.Transaction = DbTransaction;
                    command.CommandText = query;
                    command.CommandType = commandType;
                    command.Parameters.AddRange(parameters);
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtSet);
                    command.Parameters.Clear();
                    return dtSet;
                }
            }
            using (var conn = new SqlConnection(ConnectionString))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                using (SqlCommand command = conn.CreateCommand())
                {
                    command.CommandTimeout = 60000;
                    command.CommandText = query;
                    command.CommandType = commandType;
                    command.Parameters.AddRange(parameters);
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtSet);
                    command.Parameters.Clear();
                }
            }
            return dtSet;
        }

        public DataTable ExecuteDataTable(string query, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            var dtSet = new DataTable();
            if (DbConnection != null && !string.IsNullOrEmpty(DbConnection.ConnectionString) && DbConnection.State != ConnectionState.Closed)
            {
                using (SqlCommand command = DbConnection.CreateCommand())
                {
                    command.CommandTimeout = 60000;
                    command.CommandText = query;
                    command.Transaction = DbTransaction;
                    command.CommandType = commandType;
                    command.Parameters.AddRange(parameters);
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtSet);
                    command.Parameters.Clear();
                    return dtSet;
                }
            }
            using (var conn = new SqlConnection(ConnectionString))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                using (SqlCommand command = conn.CreateCommand())
                {
                    command.CommandTimeout = 60000;
                    command.CommandText = query;
                    command.CommandType = commandType;
                    command.Parameters.AddRange(parameters);
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtSet);
                    command.Parameters.Clear();
                }
            }
            return dtSet;
        }

        private SqlDbType GetDBType(Type theType)
        {
            var pr = new SqlParameter();
            var tc = TypeDescriptor.GetConverter(pr.DbType);
            if (tc.CanConvertFrom(theType))
            {
                var convertFrom = tc.ConvertFrom(theType.Name);
                if (convertFrom != null) pr.DbType = (DbType)convertFrom;
            }
            else
            {
                try
                {
                    var convertFrom = tc.ConvertFrom(theType.Name);
                    if (convertFrom != null) pr.DbType = (DbType)convertFrom;
                }
                catch (Exception)
                {
                    //Do Nothing; will return NVarChar as default
                }
            }
            return pr.SqlDbType;
        }

        private string GetSqlType(DataColumn col, string def)
        {
            var sqltype = string.Empty;
            if (col.DataType == typeof(string))
            {
                sqltype = "NVARCHAR(MAX)";
            }
            else if (col.DataType == typeof(int))
            {
                sqltype = "INT";
            }
            else if (col.DataType == typeof(DateTime))
            {
                sqltype = "DATETIME";
            }
            else if (col.DataType == typeof(float))
            {
                sqltype = "FLOAT(MAX)";
            }
            else if (col.DataType == typeof(decimal))
            {
                sqltype = "DECIMAL(19,6)";
            }
            else if (col.DataType == typeof(char))
            {
                sqltype = "CHAR(MAX)";
            }
            else if (col.DataType == typeof(TimeSpan))
            {
                sqltype = "TIME";
            }
            else
            {
                sqltype = "VARBINARY(MAX)";
            }

            return sqltype;
        }

        private string GetDefaultString()
        {
            try
            {
                var builder = new SqlConnectionStringBuilder(ConnectionString);
                var database = builder.InitialCatalog;
                var sql = string.Format("SELECT DATABASEPROPERTYEX('{0}', 'Collation') as Coll", database);
                var resp = ExecuteDataTable(sql);
                if (resp != null && resp.Rows.Count > 0)
                {
                    return resp.Rows[0]["Coll"].ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }

        public void BulkCopy(DataTable dt, string tblName)
        {
            if (DbConnection != null)
            {
                if (string.IsNullOrEmpty(DbConnection.ConnectionString))
                {
                    DbConnection.ConnectionString = ConnectionString;
                }
                if (DbConnection.State == ConnectionState.Closed)
                {
                    DbConnection.Open();
                }
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(DbConnection, SqlBulkCopyOptions.Default, DbTransaction))
                {
                    // The table I'm loading the data to
                    bulkCopy.DestinationTableName = "[" + tblName + "]";
                    // How many records to send to the database in one go (all of them)
                    bulkCopy.BatchSize = 1000;
                    bulkCopy.BulkCopyTimeout = 60000;
                    // Load the data to the database
                    bulkCopy.WriteToServer(dt);
                    // Close up          
                    bulkCopy.Close();
                }
                return;
            }
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(ConnectionString))
            {
                // The table I'm loading the data to
                bulkCopy.DestinationTableName = "[" + tblName + "]";
                // How many records to send to the database in one go (all of them)
                bulkCopy.BatchSize = 5000;
                bulkCopy.BulkCopyTimeout = 60000;
                // Load the data to the database
                bulkCopy.WriteToServer(dt);
                // Close up          
                bulkCopy.Close();
            }
        }

        public void CreateTempTable(DataTable dt, string tblName)
        {
            var stringDefault = GetDefaultString();
            var sql = string.Format(@"BEGIN TRY               
                                DROP TABLE [{0}]                              
                                END TRY
                                BEGIN CATCH
                                END CATCH {1}", tblName, Environment.NewLine);
            var cols = new List<string>();
            for (var i = 0; i < dt.Columns.Count; i++)
            {
                var col = dt.Columns[i];
                var item = string.Format("[{0}] {1} {2}", col.ColumnName, GetSqlType(col, stringDefault), col.AllowDBNull ? "NULL" : "NOT NULL");
                cols.Add(item);
            }
            sql += string.Format("CREATE TABLE [{0}]({1})", tblName, string.Join(",\r\n", cols.ToArray()));
            ExecuteNonQuery(sql);
        }

        public DataTable GetTableStructure(string tableName)
        {
            var query = string.Format("SELECT TOP 0 * FROM {0}", tableName);
            return ExecuteDataTable(query);
        }
    }
}
