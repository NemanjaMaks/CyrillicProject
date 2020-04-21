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
        public async Task<String> Query(String query)
        {
            if (query.Equals(""))
            {
                return "Insert a API request query!";
            }

            HttpResponseMessage response = await client.GetAsync(query);
            if (response.IsSuccessStatusCode)
            {
                APICall call = new APICall();
                call.Request = query;
                call.Date = System.DateTime.Now;
                call.Username = User.Identity.GetUserName();
                db.APICalls.Add(call);
                db.SaveChanges();
                String resp = await response.Content.ReadAsStringAsync();
                return resp;
            }
            else
            {
                return "Error: Bad request!";
            }

        }
    }
}