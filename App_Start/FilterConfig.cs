using System.Web;
using System.Web.Mvc;

namespace Juan_Cronje___7987___SA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
