using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Factories;

namespace Tasker.BL.Providers
{
    public class SheetDataProvider
    {
        public SheetDataProvider(
            SheetsServiceFactory sheetsServiceFactory)
        {
            SheetsServiceFactory = sheetsServiceFactory;
        }

        private SheetsServiceFactory SheetsServiceFactory { get; }

        public string GetData()
        {
            var service = SheetsServiceFactory.Create();
            
            return null;
        }
    }
}
