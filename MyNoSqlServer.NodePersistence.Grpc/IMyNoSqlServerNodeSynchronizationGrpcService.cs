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
        
        [DataMember(Order = 2)]
        public SyncGrpcHeader[] Headers { get; set; }
        
        [DataMember(Order = 3)]
        public TableAttributeGrpcModel TableAttributes { get; set; }
        
        [DataMember(Order = 4)]
        public byte[] InitTableData { get; set; }
        
        [DataMember(Order = 5)]
        public byte[] InitPartitionData { get; set; }
        
        [DataMember(Order = 6)]
        public byte[] UpdateRowsData { get; set; }

        [DataMember(Order = 7)]
        public string[] DeleteRows { get; set; }
    }
    
    
    [ServiceContract(Name = "synchronization.MyNoSqlServer")]
    public interface IMyNoSqlServerNodeSynchronizationGrpcService
    {
        [OperationContract(Action = "Sync")]
        public ValueTask<SyncGrpcResponse> SyncAsync(SyncGrpcRequest request);
    }
}