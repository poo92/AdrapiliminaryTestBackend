using EntityClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Interfaces
{
    public interface IAccountBalanceService
    {
        List<AccountBalance> GetAccountBalances();

        List<Transaction> GetTransactions(int accountType);
    }
}
