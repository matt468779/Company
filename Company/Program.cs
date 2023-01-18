using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Company.Forms;

namespace Company
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkX1pFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSH9bdk1jWH1YdXJXQA==;Mgo+DSMBPh8sVXJ0S0J+XE9AdVRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31Td0RrWXdecXZTQ2daVw==;ORg4AjUWIQA/Gnt2VVhkQlFaclxJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRiUX9WcHVXQGVVUUI=;OTYyMDAzQDMyMzAyZTM0MmUzME1tSzRxMWZ0NWkxMTV5UmwxQVNKcjVXck4xYkJvbkpORkRYaHUvei81OFU9;OTYyMDA0QDMyMzAyZTM0MmUzMEJHdDR1M3VwWDVSd1hqSEZsc1RoMGxoU2RQUy9XOWF0dkFhWmxCb1hyK1k9;NRAiBiAaIQQuGjN/V0Z+WE9EaFtBVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUViWHdeeHRURGZaV0dw;OTYyMDA2QDMyMzAyZTM0MmUzMGtsajUwczlMMDZTZ0xGOEVkUXR1RFljYU92cmcxd0NObkY4d1FqRnNicDg9;OTYyMDA3QDMyMzAyZTM0MmUzMEFsYmtQYzVRTDJJSG1IZFc1aU9hNHN4SStzU1BFUWZrZVVrdk1oTUZZQkk9;Mgo+DSMBMAY9C3t2VVhkQlFaclxJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRiUX9WcHVXQGdfVUI=;OTYyMDA5QDMyMzAyZTM0MmUzMFFUeWFuY2U3WEZ0T1NpV0tUTHVZWmdaYzQ1MHNGcGZxN0FReVNpTlMwNm89;OTYyMDEwQDMyMzAyZTM0MmUzMElzaCtBM1RxMUVtTU4xTHRtamJBbUZDOTNKN3pvS1BoRS8vWGZKTUFwbkk9;OTYyMDExQDMyMzAyZTM0MmUzMGtsajUwczlMMDZTZ0xGOEVkUXR1RFljYU92cmcxd0NObkY4d1FqRnNicDg9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
