using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MyAccounts.Libraries.Helpers;
using MyAccounts.Libraries.Security;
using Newtonsoft.Json;

namespace MyAccounts.Forms
{
    public static class WinCommons
    {
        public static void OpenCursorProcessing(XtraForm form)
        {
            form.Cursor = Cursors.WaitCursor;
        }

        public static void CloseCursorProcessing(XtraForm form)
        {
            form.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Show Message Box Dialog
        /// </summary>
        /// <param name="messageContent"></param>
        /// <param name="messageTitle"></param>
        /// <param name="messageType"></param>
        /// <returns></returns>
        public static DialogResult ShowMessageDialog(string messageContent, Enums.MessageBoxType messageType)
        {
            try
            {
                var messageTitle = string.Empty;
                var messageButton = MessageBoxButtons.OK;
                var messageIcon = MessageBoxIcon.Information;

                switch (messageType)
                {
                    case Enums.MessageBoxType.Information:
                        messageTitle = GlobalData.DefaultLanguage == "en-US" ? @"Information" : @"Thông báo";
                        messageButton = MessageBoxButtons.OK;
                        messageIcon = MessageBoxIcon.Information;
                        break;
                    case Enums.MessageBoxType.Error:
                        messageTitle = GlobalData.DefaultLanguage == "en-US" ? @"Error" : @"Lỗi";
                        messageButton = MessageBoxButtons.OK;
                        messageIcon = MessageBoxIcon.Error;
                        break;
                    case Enums.MessageBoxType.Warnings:
                        messageTitle = GlobalData.DefaultLanguage == "en-US" ? @"Warning" : @"Cảnh báo";
                        messageButton = MessageBoxButtons.OK;
                        messageIcon = MessageBoxIcon.Warning;
                        break;
                    case Enums.MessageBoxType.Question:
                        messageTitle = GlobalData.DefaultLanguage == "en-US" ? @"Confirm" : @"Xác nhận";
                        messageButton = MessageBoxButtons.YesNo;
                        messageIcon = MessageBoxIcon.Question;
                        break;
                }
                return XtraMessageBox.Show(messageContent, messageTitle, messageButton, messageIcon);
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                throw;
            }
        }
        /// <summary>
        /// Generate connection string database
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="database"></param>
        /// <returns></returns>
        public static string GetConnectionString(string serverName, string database)
        {
            return string.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1}", serverName, database);
        }

        /// <summary>
        /// Generate connection string database
        /// </summary>
        /// <param name="server"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="database"></param>
        /// <returns></returns>
        public static string GetConnectionString(string serverName, string username, string password, string database)
        {
            return string.Format(@"Persist Security Info=True;Data Source={0};Initial Catalog={1};User ID={2};Password={3}", serverName, database, username, password);
        }

        /// <summary>
        /// Connect to server with Windows authentication
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="database"></param>
        /// <returns></returns>
        public static bool CheckConnection(string serverName, string database = "master")
        {
            var connectionString = string.Format(@"Data Source={0}; Initial Catalog={1}; Integrated Security=True", serverName, database);
            var dbConnection = new SqlConnection(connectionString);
            if (dbConnection.State == ConnectionState.Closed || dbConnection.State == ConnectionState.Broken)
            {
                dbConnection.Open();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Connect to server with Server authentication
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool CheckConnection(string serverName, string userName, string password, string database = "master")
        {
            var connectionString = string.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2};Password={3}",
                    serverName, database, userName, password);
            var dbConnection = new SqlConnection(connectionString);
            if (dbConnection.State == ConnectionState.Closed || dbConnection.State == ConnectionState.Broken)
            {
                dbConnection.Open();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Write configurations
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="auth"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="databaseName"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        public static bool WriteConfiguration(string serverName, string auth, string username, string password, string databaseName, string language)
        {
            try
            {
                if (File.Exists(GlobalData.CONFIG_PATH))
                {
                    File.Delete(GlobalData.CONFIG_PATH);
                }

                var dicData = new Dictionary<string, string>();
                dicData.Add("ServerName", RSASecurity.Encrypt(serverName));
                dicData.Add("Authentication", RSASecurity.Encrypt(auth));
                dicData.Add("ServerUser", RSASecurity.Encrypt(username));
                dicData.Add("ServerPassword", RSASecurity.Encrypt(password));
                dicData.Add("DatabaseProvider", RSASecurity.Encrypt("MSSQL"));
                dicData.Add("DatabaseName", RSASecurity.Encrypt(databaseName));
                dicData.Add("DefaultLanguage", RSASecurity.Encrypt(language));

                var jsonData = JsonConvert.SerializeObject(dicData);
                File.WriteAllText(GlobalData.CONFIG_PATH, jsonData);
                return File.Exists(GlobalData.CONFIG_PATH);
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                return false;
            }
        }
    }
}
