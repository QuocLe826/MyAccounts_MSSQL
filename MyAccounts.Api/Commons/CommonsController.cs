using System;
using MyAccounts.Services.Commons;

namespace MyAccounts.Api.Commons
{
    public class CommonsController: BaseController
    {
        private CommonsService _service = null;
        public CommonsController()
        {
             _service = new CommonsService(ConnectionString);
        }

        public Tuple<string, string> InsertUserInfo(string firstName, string lastName, string userName, string password)
        {
            return _service.InsertUserInfo(firstName, lastName, userName, password);
        }

        public Tuple<string, string> BackupDatabase(string path)
        {
            return _service.BackupDatabase(path);
        }

        public Tuple<string, string> RestoreDatabase(string path)
        {
            return _service.RestoreDatabase(path);
        }
    }
}
