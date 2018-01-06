using AdraPiliminaryTest.AppModels;
using BusinessLogicLayer.Services.Interfaces;
using EntityClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AdraPiliminaryTest.AppControllers
{
    //enable cors
    [EnableCors(origins: "http://localhost:9000", headers: "*", methods: "*")]
    public class AccountBalanceController : ApiController
    {
        private IAccountBalanceService _AccountBalanceService; // create object of AccountBalanceService in BL

        public AccountBalanceController(IAccountBalanceService accountBalanceService)
        {
            _AccountBalanceService = accountBalanceService;
        }
        
        // method to get account balances
        [Route("api/AccountBalance/GetAccountBalances")]
        [HttpPost]
        public List<AccountBalance> GetAccountBalances()
        {
            return _AccountBalanceService.GetAccountBalances();
        }

        // method to get transactions
        [Route("api/AccountBalance/GetTransactions")]
        [HttpPost]
        public List<Transaction> GetTransactions(UserRequest userRequest)
        {
            int accountType = userRequest.accountType;
            return _AccountBalanceService.GetTransactions(accountType);
        }
    }
}