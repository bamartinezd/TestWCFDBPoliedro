using System.Web;
using System.Web.Mvc;

namespace TestWCFDBPoliedro.GUI.MvcFront
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
