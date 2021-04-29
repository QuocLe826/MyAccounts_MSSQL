using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Logging;
using MyAccounts.Forms.Commons;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace MyAccounts.Forms
{
    public static class WinCommons
    {
        /// <summary>
        /// Open Processing dialog
        /// </summary>
        /// <param name="description"></param>
        public static void OpenProcessing(string description)
        {
            Processing.Descriptions = description;
            SplashScreenManager.ShowForm(typeof(Processing));
        }

        /// <summary>
        /// Close Processing dialog
        /// </summary>
        public static void CloseProcessing()
        {
            SplashScreenManager.CloseForm(false);
        }
        /// <summary>
        /// Show Message Box Dialog
        /// </summary>
        /// <param name="messageContent"></param>
        /// <param name="messageTitle"></param>
        /// <param name="messageType"></param>
        /// <returns></returns>
        public static DialogResult ShowMessageDialog(string messageContent, string messageTitle, Enums.MessageBoxType messageType)
        {
            try
            {

                var messageButton = MessageBoxButtons.OK;
                var messageIcon = MessageBoxIcon.Information;

                switch (messageType)
                {
                    case Enums.MessageBoxType.Information:
                        messageButton = MessageBoxButtons.OK;
                        messageIcon = MessageBoxIcon.Information;
                        break;
                    case Enums.MessageBoxType.Error:
                        messageButton = MessageBoxButtons.OK;
                        messageIcon = MessageBoxIcon.Error;
                        break;
                    case Enums.MessageBoxType.Warnings:
                        messageButton = MessageBoxButtons.OK;
                        messageIcon = MessageBoxIcon.Warning;
                        break;
                    case Enums.MessageBoxType.Question:
                        messageButton = MessageBoxButtons.YesNo;
                        messageIcon = MessageBoxIcon.Question;
                        break;
                    case Enums.MessageBoxType.Retry:
                        messageButton = MessageBoxButtons.RetryCancel;
                        messageIcon = MessageBoxIcon.Error;
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
    }
}
