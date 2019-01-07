using JsonPlaceHolder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace JsonPlaceHolder.Web.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Users()
        {
            return View(GetAllUsers());
        }
        
        public ActionResult Posts(string userId, string postId)
        {
            ViewBag.PostId = null;
            ViewBag.UserId = null;

            if (!string.IsNullOrWhiteSpace(userId))
            {
                ViewBag.UserId = userId;

                if(!string.IsNullOrWhiteSpace(postId))
                {
                    ViewBag.PostId = postId;
                }
                return View();
            }            
            else
            {
                return View();
            }
        }
        private List<User> GetAllUsers()
        {
            var baseUrl = System.Configuration.ConfigurationManager.AppSettings["ApiURL"];

            List<User> response = null;

            try
            {
                var client = new HttpClient();
                int apiTimeoutValue = 6000;
                client.Timeout = TimeSpan.FromSeconds(apiTimeoutValue);
                var httpResponse = client.GetAsync(baseUrl).ContinueWith(task => task.Result).Result;

                if (httpResponse.IsSuccessStatusCode && !string.IsNullOrEmpty(httpResponse.Content.ReadAsStringAsync().Result))
                {
                    var httpResponseResult = httpResponse.Content.ReadAsStringAsync().ContinueWith(task => task.Result).Result;
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    response = serializer.Deserialize<List<User>>(httpResponseResult);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return response;
        }
       
        
    }
}