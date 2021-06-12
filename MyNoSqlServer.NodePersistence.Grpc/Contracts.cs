using System.Runtime.Serialization;

namespace MyNoSqlServer.NodePersistence.Grpc
{
    [DataContract]
    public class PayloadWrapperGrpcModel
    {
        [DataMember(Order = 1)]
        public byte[] Payload { get; set; }
    }
    
    
    [DataContract]
    public class SaveSnapshotGrpcModel
    {
        [DataMember(Order = 1)]
        public string TableName { get; set; }
        
        [DataMember(Order = 2)]
        public byte[] Content { get; set; }
    }

    [DataContract]
    public class DeleteTablePartitionGrpcRequest
    {
        [DataMember(Order = 1)]
        public string TableName { get; set; }
        
        [DataMember(Order = 2)]
        public string[] PartitionKeys { get; set; }
    }

    [DataContract]
    public class SetTableAttributesGrpcRequest
    {
        [DataMember(Order = 1)]
        public string TableName { get; set; }
        
        [DataMember(Order = 2)]
        public bool Persist { get; set; }

        [DataMember(Order = 3)]
        public int MaxPartitionsAmount { get; set; }
    }
    
    
    [DataContract]
    public class GetTableGrpcResponse
    {
        [DataMember(Order = 1)]
        public string TableName { get; set; }
        
        [DataMember(Order = 2)]
        public bool Persist { get; set; }

        [DataMember(Order = 3)]
        public int MaxPartitionsAmount { get; set; }
    }

    [DataContract]
    public class DownloadTableGrpcRequest
    {
        [DataMember(Order = 1)]
        public string TableName { get; set; }
    }
    

}