// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// ----------------------------------------------------------------------------

namespace UserOwnsData
{
	using Owin;
	using UserOwnsData.Services.Security;

	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			// // init ASP.NET MVC routes
			// AreaRegistration.RegisterAllAreas();
			// RouteConfig.RegisterRoutes(RouteTable.Routes);
			// 
			// // init OpenId Connect settings
			// OwinOpenIdConnect.ConfigureAuth(app);
		}
	}
}