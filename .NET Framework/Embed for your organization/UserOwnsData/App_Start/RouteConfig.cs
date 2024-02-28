// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// ----------------------------------------------------------------------------

using Microsoft.AspNetCore.Routing;

namespace UserOwnsData
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			// #todo #jovaneen
			// routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			// routes.MapRoute(
			// 	name: "Default",
			// 	url: "{controller}/{action}/{id}",
			// 	defaults: new { controller = "Home", action = "Index" } // , id = UrlParameter.Optional }
			// );
		}
	}
}
