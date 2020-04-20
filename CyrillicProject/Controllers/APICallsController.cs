using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using CyrillicProject.Models;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CyrillicProject.Controllers
{
    public class APICallsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        static HttpClient client = new HttpClient();

        public ActionResult Query()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Query(APICall query)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            HttpResponseMessage response = await client.GetAsync(query.Request);
            if (response.IsSuccessStatusCode)
            {
                String resp = await response.Content.ReadAsStringAsync();
                return Content(resp,"text/json");
            }
            return View();
        }
    }
}