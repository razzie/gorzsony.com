﻿using Owin;
using Nancy.Owin;
using System.Net;

class Startup
{
    public void Configuration(IAppBuilder app)
    {
        //var listener = (HttpListener)app.Properties["System.Net.HttpListener"];
        //listener.AuthenticationSchemes = AuthenticationSchemes.IntegratedWindowsAuthentication;
        app.UseNancy();
    }
}
