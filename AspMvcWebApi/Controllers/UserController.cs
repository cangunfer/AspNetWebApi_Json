using AspMvcWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspMvcWebApi.Controllers
{
    public class UserController : ApiController
    {
       [HttpGet]
       public IEnumerable<User>Users()
        {

            return Database._Database.ToList();
        }
    }
}
