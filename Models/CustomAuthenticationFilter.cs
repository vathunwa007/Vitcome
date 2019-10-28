using System;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using Microsoft.AspNetCore.Http;
using ActionFilterAttribute = Microsoft.AspNetCore.Mvc.Filters.ActionFilterAttribute;

namespace netcore.Models
{
     public class CustomAuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            /*if (string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Session.GetString("username"))))
           {
                filterContext.Result = new HttpUnauthorizedResult();
            }*/
        }
        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new System.Web.Mvc.ViewResult()
                {
                    ViewName = "Index",
                };
                //Redirecting the user to the Login View of Account Controller
                //If you want to redirect to some error view, use below code
                //filterContext.Result = new ViewResult()
                //{
                //    ViewName = "Login"
                //};
            }
        }
    }

}