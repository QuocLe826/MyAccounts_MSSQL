using System.Collections.Generic;
using System.Data;
using MyAccounts.Services.Categories;

namespace MyAccounts.Api.Categories
{
    public class AccountManagementController: BaseController
    {
        private AccountManagementService _service = null;

        public AccountManagementController()
        {
            _service = new AccountManagementService(ConnectionString);
        }

        public DataTable GetAccountGroups()
        {
            return _service.GetAccountGroups();
        }

        public DataTable GetAccountType()
        {
            return _service.GetAccountType();
        }

        public DataTable GetAccountManagement()
        {
            return _service.GetAccountManagement();
        }

        public DataTable GetAccountManagementByCode(string code)
        {
            return _service.GetAccountManagementByCode(code);
        }

        public DataTable SearchData(string username, string accGroup, string accType)
        {
            return _service.SearchData(username, accGroup, accType);
        }

        public string ProcessData(Dictionary<string, string> dicData, string actionType)
        {
            return _service.ProcessData(dicData, actionType);
        }

        public string DeleteAccount(string code)
        {
            return _service.DeleteAccount(code);
        }
    }
}
