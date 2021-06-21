using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;

namespace MyNoSqlServer.NodePersistence.Grpc
{


    
    
    
    
    [ServiceContract(Name = "synchronization.MyNoSqlServer")]
    public interface IMyNoSqlServerNodeSynchronizationGrpcService
    {
        [OperationContract(Action = "Sync")]
        public ValueTask<SyncTransactionGrpcModel> SyncAsync(SyncGrpcRequest request);
        
        [OperationContract(Action = "SyncCompressed")]
        public ValueTask<PayloadWrapperGrpcModel> SyncCompressedAsync(SyncGrpcRequest request);
    }
}