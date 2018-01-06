using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IAccountBalanceRepository
    {
        List<accountBalance> GetAccountBalances();
        List<transaction> GetTransactions(int accountType);
    }
}
