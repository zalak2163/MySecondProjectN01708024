using System.Web;
using System.Web.Mvc;

namespace MySecondProjectN01708024
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
