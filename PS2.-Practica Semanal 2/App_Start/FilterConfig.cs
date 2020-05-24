using System.Web;
using System.Web.Mvc;

namespace PS2._Practica_Semanal_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
