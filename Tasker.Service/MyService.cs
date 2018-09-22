﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Microsoft.Owin.Hosting;
using Tasker.Service.Properties;

namespace Tasker.Service
{
    partial class MyService : ServiceBase
    {
        private ILogger Logger { get; }

        public MyService(ILogger logger)
        {
            Logger = logger;
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Start();
        }

        protected override void OnStop()
        {
            Logger.Info("Wyłączono usługe " + DateTime.Now);
        }

        public void Start()
        {
            var url = Settings.Default.WebUrl;

            WebApp.Start(url);

            Logger.Info($"Uruchomiono usługe {DateTime.Now}, IP: {url}");
        }
    }
}
