using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace MyAccounts.Libraries.Logging
{
    public static class Logging
    {
        public const string ERROR = "ERROR";
        public const string WATCH = "WATCH";
        public const string TRACE = "TRACE";

        public static bool Write(string errorType, params string[] arrMess)
        {
            var bRet = false;
            var timeNow = DateTime.Now;
            try
            {
                //Đặt tên file log
                var appDomain = AppDomain.CurrentDomain;
                var basePath = appDomain.BaseDirectory;
                var sPath = Path.Combine(basePath, "Log\\" + timeNow.ToString("yyyy") + "\\" + timeNow.ToString("MM"));
                var directoryInfo = new DirectoryInfo(sPath);
                if (directoryInfo.Exists == false)
                {
                    //Neu khong ton tai thu muc ghi log 
                    directoryInfo.Create(); //Tao moi thu muc ghi log
                }
                var filenameLog = AutoRenameFile(sPath, "Log-" + timeNow.ToString("yyyyMMdd")) + ".txt";

                var fileLog = String.Format("{0}\\{1}", sPath, filenameLog);

                // Bắt đầu ghi log
                var strInfor = String.Format("[{0}]\t{1:yyyy-MM-dd}\t{2:HH:mm:ss:fff}", errorType.ToUpper(), timeNow, timeNow);
                //strInfor += "\t";
                foreach (var str in arrMess)
                {
                    strInfor += "\t" + str.Replace("\n", "").Replace("\r", "");
                }
                //strInfor = arrMess.Aggregate(strInfor, (current, mess) => current + (mess + "\t"));
                strInfor += Environment.NewLine;
                var fileStream = new FileStream(fileLog, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                fileStream.Write(Encoding.UTF8.GetBytes(strInfor), 0, Encoding.UTF8.GetByteCount(strInfor));
                // Ghi dong log vao file
                fileStream.Close();
                fileStream.Dispose();
            }
            catch
            {
                bRet = false;
            }
            finally
            {
                GC.Collect();
            }
            bRet = true;

            return bRet;
        }

        public static bool Write(string errorType, Exception ex)
        {
            var bRet = false;
            var timeNow = DateTime.Now;
            try
            {
                //Đặt tên file log
                var appDomain = AppDomain.CurrentDomain;
                var basePath = appDomain.BaseDirectory;
                var sPath = Path.Combine(basePath, "Log\\" + timeNow.ToString("yyyy") + "\\" + timeNow.ToString("MM"));
                var directoryInfo = new DirectoryInfo(sPath);
                if (directoryInfo.Exists == false)
                {
                    //Neu khong ton tai thu muc ghi log 
                    directoryInfo.Create(); //Tao moi thu muc ghi log
                }
                var filenameLog = AutoRenameFile(sPath, "Log-" + timeNow.ToString("yyyyMMdd")) + ".txt";

                var fileLog = String.Format("{0}\\{1}", sPath, filenameLog);

                // Bắt đầu ghi log
                var strInfor = String.Format("[{0}]\t{1:yyyy-MM-dd}\t{2:HH:mm:ss:fff}", errorType.ToUpper(), timeNow, timeNow);
                //strInfor += "\t";

                // Get stack trace for the exception with source file information
                var st = new StackTrace(ex, true);

                var frame = st.GetFrame(st.FrameCount - 1);
                var methods = frame.GetMethod().DeclaringType.FullName;
                var line = frame.GetFileLineNumber();

                strInfor += "\t" + ex.Message + "\t" + methods + ">\t" + line;

                //strInfor = arrMess.Aggregate(strInfor, (current, mess) => current + (mess + "\t"));
                strInfor += Environment.NewLine;
                var fileStream = new FileStream(fileLog, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                fileStream.Write(Encoding.UTF8.GetBytes(strInfor), 0, Encoding.UTF8.GetByteCount(strInfor));
                // Ghi dong log vao file
                fileStream.Close();
                fileStream.Dispose();
            }
            catch
            {
                bRet = false;
            }
            finally
            {
                GC.Collect();
            }
            bRet = true;

            return bRet;
        }
        private static string AutoRenameFile(string folderPath, string fileName)
        {
            try
            {
                var allFiles = Directory.GetFiles(folderPath)
                        .Select(Path.GetFileNameWithoutExtension)
                        .ToArray();

                if (allFiles.Length == 0)
                {
                    return fileName;
                }
                FileInfo fileInfo = null;
                if (allFiles.Length == 1)
                    fileInfo = new FileInfo(folderPath + "\\" + fileName + ".html");
                else
                    fileInfo =
                        new FileInfo(folderPath + "\\" + String.Format("{0} ({1})", fileName, allFiles.Length - 1) +
                                     ".txt");
                if (fileInfo.Length >= 1048576)
                {
                    fileName = String.Format("{0} ({1})", fileName, allFiles.Length);
                }
                else if (allFiles.Length != 1)
                    fileName = String.Format("{0} ({1})", fileName, allFiles.Length - 1);
                return fileName;
            }
            catch (Exception)
            {
                return fileName;
            }
        }
    }
}