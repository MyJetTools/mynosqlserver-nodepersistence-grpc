using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;

namespace MyNoSqlServer.NodePersistence.Grpc
{

    [DataContract]
    public class SyncGrpcRequest
    {
        [DataMember(Order = 1)]
        public string Location { get; set; }
        
        [DataMember(Order = 2)]
        public string SessionId { get; set; }
        
        [DataMember(Order = 3)]
        public long RequestId { get; set; }
    }
    
    
    [DataContract]
    public class SyncGrpcHeader{
        
        [DataMember(Order = 1)]
        public string Key { get; set; }
        
        [DataMember(Order = 2)]
        public string Value { get; set; }
    }
    

    [DataContract]
    public class SyncGrpcResponse
    {
        
        [DataMember(Order = 1)]
        public string TableName { get; set; }
        
        [DataMember(Order = 1)]
        public SyncGrpcHeader[] Headers { get; set; }
        
        [DataMember(Order = 2)]
        public byte[] InitTable { get; set; }
        
        [DataMember(Order = 3)]
        public byte[] InitPartition { get; set; }
        
        [DataMember(Order = 4)]
        public byte[] UpdateRows { get; set; }

        [DataMember(Order = 5)]
        public string[] DeleteRows { get; set; }
    }
    
    
    [ServiceContract(Name = "synchronization.MyNoSqlServer")]
    public interface IMyNoSqlServerNodeSynchronizationGrpcService
    {
        [OperationContract(Action = "Sync")]
        public ValueTask<SyncGrpcResponse> SyncAsync(SyncGrpcRequest request);
    }
}