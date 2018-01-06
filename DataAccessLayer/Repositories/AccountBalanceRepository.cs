using DataAccessLayer;
using DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AccountBalanceRepository : IAccountBalanceRepository
    {
        private adrapiliminary DbContext;
        public AccountBalanceRepository()
        {
            DbContext = new adrapiliminary();
        }

        // method to view account balances
        public List<accountBalance> GetAccountBalances()
        {
            List<accountBalance> resultList = DbContext.accountBalances.ToList();
            return resultList;
        }

        // method to view transactions
        public List<transaction> GetTransactions(int accountType)
        {
            List<transaction> resultList = DbContext.transactions.Where(o => o.AccountType == accountType).ToList();
            return resultList;

        }

    }
}
