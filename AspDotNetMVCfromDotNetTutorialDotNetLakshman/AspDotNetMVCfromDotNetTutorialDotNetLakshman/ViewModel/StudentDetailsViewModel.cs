using AspDotNetMVCfromDotNetTutorialDotNetLakshman.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspDotNetMVCfromDotNetTutorialDotNetLakshman.ViewModel
{
    public class StudentDetailsViewModel
    {

        public Student Student { get; set; }
        public Address Address { get; set; }
        public string PageTitle { get; set; }
        public string PageHeader { get; set; }

    }
}