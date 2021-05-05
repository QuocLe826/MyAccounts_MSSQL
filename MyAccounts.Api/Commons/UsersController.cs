using System.Data;
using MyAccounts.Services.Commons;

namespace MyAccounts.Api.Commons
{
    public class UsersController: BaseController
    {
        private UsersService _service = null;
        public UsersController()
        {
            _service = new UsersService(ConnectionString);
        }

        public string Login(string username, string password)
        {
            return _service.Login(username, password);
        }

        public DataTable GetUserInfo(string username)
        {
            return _service.GetUserInfo(username);
        }

        public string ChangePassword(string username, string curPassword, string newPassword, string confirmPassword)
        {
            return _service.ChangePassword(username, curPassword, newPassword, confirmPassword);
        }
    }
}
