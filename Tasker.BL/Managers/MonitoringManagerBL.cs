using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Extensions;
using Tasker.BL.Factories;
using Tasker.BL.Providers;
using Tasker.BL.Pub.Managers;

namespace Tasker.BL.Managers
{
    public class MonitoringManagerBL : IMonitoringManagerBL
    {
        public MonitoringManagerBL(
            SheetRowModelFactory sheetModelFactory,
            SheetDataProvider sheetDataProvider)
        {
            SheetModelFactory = sheetModelFactory;
            SheetDataProvider = sheetDataProvider;
        }

        private SheetRowModelFactory SheetModelFactory { get; }
        private SheetDataProvider SheetDataProvider { get; }

        public void Begin()
        {
            var datas = SheetDataProvider.GetData();

            var model = SheetModelFactory.Create(datas);
        }
    }
}
