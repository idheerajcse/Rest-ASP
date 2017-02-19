using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace REST_WCF_App
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceRest" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceRest.svc or ServiceRest.svc.cs at the Solution Explorer and start debugging.
    public class ServiceRest : IServiceRest
    {

        public string getAllData(string val)
        {
            return "Hello i am from rest Api";
        }
    }
}
