using System.Data;
using MyAccounts.Services.Categories;

namespace MyAccounts.Api.Categories
{
    public class AccountTypeController : BaseController
    {
        private AccountTypeService _service = null;

        public AccountTypeController()
        {
            _service = new AccountTypeService(ConnectionString);
        }

        public DataTable GetAccountType()
        {
            return _service.GetAccountType();
        }

        public DataTable SearchAccountType(string code, string name, string status, string descriptions)
        {
            return _service.SearchAccountType(code, name, status, descriptions);
        }

        public string ProcessAccountType(DataTable dt, string actionType)
        {
            return _service.ProcessAccountType(dt, actionType);
        }

        public string DeleteAccountType(string code)
        {
            return _service.DeleteAccountType(code);
        }
    }
}
