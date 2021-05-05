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

        public string InsertUserInfo(string firstName, string lastName, string userName, string password)
        {
            return _service.InsertUserInfo(firstName, lastName, userName, password);
        }

        public string BackupDatabase(string path)
        {
            return _service.BackupDatabase(path);
        }

        public string RestoreDatabase(string path)
        {
            return _service.RestoreDatabase(path);
        }
    }
}
