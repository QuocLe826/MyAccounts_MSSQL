using System.Data;
using MyAccounts.Services.Categories;

namespace MyAccounts.Api.Categories
{
    public class AccountGroupsController: BaseController
    {
        private AccountGroupsService _service = null;

        public AccountGroupsController()
        {
            _service = new AccountGroupsService(ConnectionString);
        }

        public DataTable GetAccountGroups()
        {
            return _service.GetAccountGroups();
        }

        public DataTable SearchAccountGroup(string code, string name, string status, string descriptions)
        {
            return _service.SearchAccountGroup(code, name, status, descriptions);
        }

        public string ProcessAccountGroups(DataTable dt, string actionType)
        {
            return _service.ProcessAccountGroups(dt, actionType);
        }

        public string DeleteAccountGroups(string code)
        {
            return _service.DeleteAccountGroups(code);
        }
    }
}
