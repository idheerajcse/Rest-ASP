using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel.Web;

namespace REST_WCF_App
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceRest" in both code and config file together.
    [ServiceContract]
    public interface IServiceRest
    {
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetData/{val}", BodyStyle = WebMessageBodyStyle.Wrapped)]
        string getAllData(string val);
        
    }
}
