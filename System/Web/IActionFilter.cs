namespace System.Web
{
    internal interface IActionFilter
    {
        void OnActionExecuting(Mvc.ActionExecutingContext filterContext);
    }
}