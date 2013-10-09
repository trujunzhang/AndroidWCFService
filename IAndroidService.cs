using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AndroidWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAndroidService
    {

        [OperationContract]
        List<string> GetAllJokes();

        [OperationContract]
        bool AddJoke(string joke);

        // TODO: Add your service operations here
    }

}
