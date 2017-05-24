﻿using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.Configuration;

namespace UI.Tests.Tests
{
    public static class BrowserHost
    {
        public static readonly SelenoHost Instance = new SelenoHost();
        //public static string RootUrl = @"http://localhost:60634/Article/List";

        static BrowserHost()
        {
            Instance.Run("Blog", 60634, w => w.WithRemoteWebDriver(() => new ChromeDriver()));
        }

    }
}
