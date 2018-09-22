using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Factories;
using Tasker.BL.Managers;
using Tasker.BL.Providers;
using Tasker.BL.Pub.Managers;

namespace Tasker.BL.Infrastructure
{
    public class Installer : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(

                 Component
                .For<SheetDataProvider>()
                .LifeStyle.Transient,

                Component
                .For<SheetsServiceFactory>()
                .LifeStyle.Transient,

                Component
                .For<SheetModelFactory>()
                .LifeStyle.Transient,

                Component
                .For<IMonitoringManagerBL>()
                .ImplementedBy<MonitoringManagerBL>()
                .LifeStyle.Transient


                );
        }
    }
}