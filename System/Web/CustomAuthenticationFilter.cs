using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using ActionFilterAttribute = Microsoft.AspNetCore.Mvc.Filters.ActionFilterAttribute;

namespace netcore.Models
{
     public class CustomAuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            /*var myCulture = filterContext.HttpContext.Session["MyCulture"] as string;

            if (filterContext.HttpContext.Session["login"] == null)

            {
                filterContext.Result = new RedirectResult("~/Home/Index"); // redirect to login action
            }
            else
            {
                // continue normal execution 
            }

    */

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