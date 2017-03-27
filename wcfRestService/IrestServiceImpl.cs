using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcfRestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IrestServiceImpl" in both code and config file together.
    [ServiceContract]
    public interface IrestServiceImpl
    {
    
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "json/{id}")]
        data readData(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "write")]
        string writeData(data rData);
    }

    [DataContract]
    public class Data
    {
        [DataMember]
        public string details { get; set; }
    }

    [DataContract]
    public class data
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Age { get; set; }

        [DataMember]
        public string Exp { get; set; }

        [DataMember]
        public string Technology { get; set; }

    }
}
