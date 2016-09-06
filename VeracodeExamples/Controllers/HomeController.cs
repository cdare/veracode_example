using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeracodeExamples.Models;

namespace VeracodeExamples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult SearchUser(String userid)
        {
            UserModel myUser = fetchUserFromLdap(userid);
            return View(myUser);
        }


        [ValidateInput(false)]
        public ActionResult SearchUserAjax(String userid)
        {
            UserModel myUser = fetchUserFromLdap(userid);
            return Content("{\"message\": \"search for userId: " + userid + "result\", \"result\": " + convertToJson(myUser) + " }");
        }

        private string convertToJson(UserModel myUser)
        {
            return "{ \"userId\": \"" + myUser.UserId + "\", \"FirstName\":\"" + myUser.FirstName + "\", \"LastName\": \"" + myUser.LastName + "\", \"Email\":\"" + myUser.Email + "\", \"Signature\": \"" + myUser.Signature + "\"}";
        }

        private UserModel fetchUserFromLdap(string userId)
        {
            var retVal = new UserModel();
            if (String.IsNullOrEmpty(userId))
            {
                retVal.UserId = "N/A";
                retVal.FirstName = "N/A";
                retVal.LastName = "N/A";
                retVal.Email = "N/A";
                retVal.Signature = "N/A";
            }
            else
            {

                retVal.UserId = userId;
                retVal.FirstName = "FirstName";
                retVal.LastName = "LastName";
                retVal.Email = "email@example.com";
                retVal.Signature = "<div style=background-color:#F0F8FF>This is my fancy signature yay!<script>alert(1)</script></ div > ";
         
            }
            return retVal;
        }

    }
}