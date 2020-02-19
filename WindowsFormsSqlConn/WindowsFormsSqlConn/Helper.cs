using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSqlConn
{
    class Helper
    {
        public static string c
        {
            get
            {
                // add rference system.configuration in References
                return ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                // fetched using name property
            }
        }
    }
}
