using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace HerosServer.Controllers
{
    [Route("api/hero")]
    public class HerosController : Controller
    {
        public DbModel Context { get; set; }

        public HerosController()
        {
            Context = new DbModel();
        }
    }
}
