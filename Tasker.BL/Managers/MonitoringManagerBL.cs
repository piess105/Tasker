using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Extensions;
using Tasker.BL.Factories;
using Tasker.BL.Providers;
using Tasker.BL.Proxies;
using Tasker.BL.Pub.Managers;
using Tasker.BL.Savers;

namespace Tasker.BL.Managers
{
    public class MonitoringManagerBL : IMonitoringManagerBL
    {
        public MonitoringManagerBL(
            SheetDataSaverProxy sheetDataSaverProxy,
            SheetRowModelFactory sheetModelFactory,
            SheetDataProvider sheetDataProvider)
        {
            SheetDataSaverProxy = sheetDataSaverProxy;
            SheetModelFactory = sheetModelFactory;
            SheetDataProvider = sheetDataProvider;
        }

        private SheetDataSaverProxy SheetDataSaverProxy { get; }
        private SheetRowModelFactory SheetModelFactory { get; }
        private SheetDataProvider SheetDataProvider { get; }

        public void Begin()
        {
            var datas = SheetDataProvider.GetData();

            var models = SheetModelFactory.Create(datas);

            var model = models[2].Cells[0];
            model.Content = "Wozek";

            SheetDataSaverProxy.Save(model);
        }
    }
}
