using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftSend.services
{
    internal class SwiftSendService
    {
        private string databaseConnectionString = ConfigurationManager.ConnectionStrings["SwiftSendDbConnection"].ConnectionString;
    }
}
