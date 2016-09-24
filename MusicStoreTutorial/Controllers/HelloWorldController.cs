using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreTutorial.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public String Index()
        {
            return "This is my <b>Default</b> action";
        }

        public string Welcome(string name, int numTimes = 1)
        {
            //return HttpUtility.HtmlEncode("Hello " + name + " ID: " + ID);
            return HttpUtility.HtmlEncode("Hello " + name + " \n Num Time is:" + numTimes);
            //return "This is the Welcome Action";
        }

    }
}