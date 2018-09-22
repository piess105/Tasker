using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Providers;
using Tasker.BL.Pub.Managers;

namespace Tasker.BL.Managers
{
    public class MonitoringManagerBL : IMonitoringManagerBL
    {
        public MonitoringManagerBL(SheetDataProvider sheetDataProvider)
        {
            SheetDataProvider = sheetDataProvider;
        }

        private SheetDataProvider SheetDataProvider { get; }

        public void Begin()
        {
            SheetDataProvider.GetData();
        }
    }
}
