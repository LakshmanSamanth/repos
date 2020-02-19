using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MVCSQLCONNECTION
{
    public class Helper
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