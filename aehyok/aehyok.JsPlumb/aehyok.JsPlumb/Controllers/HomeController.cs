using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aehyok.JsPlumb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //https://github.com/restsharp/RestSharp

            var client = new RestClient("http://localhost:2088");


            var request = new RestRequest("/api/Flow/GetCaseFlowInfo?ajid=1", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}