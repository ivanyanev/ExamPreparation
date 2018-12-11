using MishMashWebApp_MyEdition.Data;
using SIS.MvcFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MishMashWebApp_MyEdition.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            this.Db = new ApplicationDbContext();
        }

        protected ApplicationDbContext Db { get; }
    }
}
