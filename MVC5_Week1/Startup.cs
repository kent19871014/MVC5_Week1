﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5_Week1.Startup))]
namespace MVC5_Week1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
