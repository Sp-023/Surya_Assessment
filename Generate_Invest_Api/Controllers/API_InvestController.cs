﻿using Generate_Invest_Api.ApiServices;
using Generate_Invest_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generate_Invest_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class API_InvestController : ControllerBase
    {
        private readonly Interface_Api_Service db;


        public API_InvestController(Interface_Api_Service Db)
        {
            db = Db;

        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/API_Invest")]
        public IEnumerable<Invest> List()
        {
            return db.GetAll();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/API_Invest")]
        public Invest AddInv(Invest In)
        {
            return db.Add_Invest(In);
        }
        [HttpPut]
        [Route("[action]")]
        [Route("api/API_Invest")]
        public Invest UpdateInv(Invest upin)
        {
            return db.Update_Invest(upin);
        }
        [HttpDelete]


        public Invest DeleteInv(int id)
        {
            return db.Delete_Invest(id);
        }
    }
}
