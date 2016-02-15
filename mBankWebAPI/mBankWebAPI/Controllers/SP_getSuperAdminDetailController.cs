using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using mBankWebAPI.Models;

namespace mBankWebAPI.Controllers
{
    public class SP_getSuperAdminDetailController : ApiController
    {
        BankEntities bankEntities = new BankEntities();
       public IEnumerable<SP_getSuperAdminDetail_Result>Get(string username)
        {
            return bankEntities.SP_getSuperAdminDetail(username).ToArray();
        }
    }
}
