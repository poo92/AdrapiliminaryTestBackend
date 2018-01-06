using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Repositories.Interfaces;
using EntityClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class AccountBalanceService : IAccountBalanceService
    {
        private IAccountBalanceRepository _AccountBalanceRepo;         // instance of a AccountBalanceRepo class on DAL

        public AccountBalanceService(IAccountBalanceRepository accountBalanceRepo)
        {
            _AccountBalanceRepo = accountBalanceRepo;
        }


        // method to view account balances
        public List<AccountBalance> GetAccountBalances()
        {
            List<AccountBalance> result = new List<AccountBalance>();

            List<accountBalance> resultList = _AccountBalanceRepo.GetAccountBalances();
            foreach (accountBalance accountBalanceObg in resultList)
            {
                AccountBalance AccountBalanceObj = new AccountBalance();
                AccountBalanceObj.rnd = (double)accountBalanceObg.rnd;
                AccountBalanceObj.canteen = (double)accountBalanceObg.canteen;
                AccountBalanceObj.ceocar = (double)accountBalanceObg.ceocar;
                AccountBalanceObj.marketing = (double)accountBalanceObg.marketing;
                AccountBalanceObj.parking = (double)accountBalanceObg.parking;

                result.Add(AccountBalanceObj);
            }
            return result;
        }

        //method to view transactions
        public List<Transaction> GetTransactions(int accountType)
        {
            List<Transaction> result = new List<Transaction>();

            List<transaction> resultList = _AccountBalanceRepo.GetTransactions(accountType);
            foreach (transaction transactionObg in resultList)
            {
                Transaction TransactionObj = new Transaction();
                TransactionObj.amount = (double)transactionObg.amount;
                TransactionObj.reference = transactionObg.reference;
                TransactionObj.date = (DateTime)transactionObg.date;
                TransactionObj.name = transactionObg.name;


                result.Add(TransactionObj);
            }
            return result;

        }
    }
}
