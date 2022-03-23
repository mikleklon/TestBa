using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using ServerBars.Model;


namespace ServerBars
{

    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Docs GetData();

    }
}
