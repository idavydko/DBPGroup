using System.Web.Mvc;

namespace DBP.UI.Framework
{
    public static class UrlHelperExtensions
    {
        public static string LogOn(this UrlHelper urlHelper, string returnUrl)
        {
            return !string.IsNullOrEmpty(returnUrl)
                       ? urlHelper.Action("Login", "Customer", new {ReturnUrl = returnUrl})
                       : urlHelper.Action("Login", "Customer");
        }

        public static string LogOff(this UrlHelper urlHelper, string returnUrl)
        {
            return !string.IsNullOrEmpty(returnUrl)
                       ? urlHelper.Action("Logout", "Customer", new {ReturnUrl = returnUrl})
                       : urlHelper.Action("Logout", "Customer");
        }
    }
}
