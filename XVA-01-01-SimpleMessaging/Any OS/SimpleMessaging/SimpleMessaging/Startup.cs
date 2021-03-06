﻿using System.Web;
using XSockets.Core.Common.Socket;

[assembly: PreApplicationStartMethod(typeof(SimpleMessaging.Startup), "Start")]
namespace SimpleMessaging
{
    public static class Startup
    {
        private static IXSocketServerContainer container;
        public static void Start()
        {
            container = XSockets.Plugin.Framework.Composable.GetExport<IXSocketServerContainer>();
            container.Start();
        }        
    }
}