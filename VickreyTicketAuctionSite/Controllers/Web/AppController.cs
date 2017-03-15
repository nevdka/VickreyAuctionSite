using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VickreyTicketAuctionSite.Controllers.Web
{
    public class AppController : Controller
    {
        public AppController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
