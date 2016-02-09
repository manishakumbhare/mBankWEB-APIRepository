using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using mBankWebAPI.Models;

namespace mBankWebAPI.Controllers
{
    public class SP_LoginCredentialsController : ApiController
    {
        BankEntities bankEntities = new BankEntities();
        public IEnumerable<SP_LoginCredentials_Result> Get(string userName,string passWord)
        {
            return bankEntities.SP_LoginCredentials(userName,passWord).ToArray();
        }
    }
}
