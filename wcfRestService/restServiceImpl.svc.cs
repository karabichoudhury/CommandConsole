using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfRestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "restServiceImpl" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select restServiceImpl.svc or restServiceImpl.svc.cs at the Solution Explorer and start debugging.
    public class restServiceImpl : IrestServiceImpl
    {
        
        public data readData(string id)
        {
            var obj = new data
            {
                Name = "Ram",
                Age = "25",
                Exp = "8",
                Technology = "Dotnet"
            };
            return obj;
        }


        public string writeData(data rData)
        {
            
            return "record inserted";
        }
    }
}
