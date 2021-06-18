using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyNoSqlServer.NodePersistence.Grpc
{
    [DataContract]
    public class PingGrpcRequest
    {
        [DataMember(Order = 1)]
        public string Location { get; set; }
    }

    [DataContract]
    public class PingGrpcResponse
    {
        [DataMember(Order = 1)]
        public string Location { get; set; }
    }
    
    [DataContract]
    public class PayloadWrapperGrpcModel
    {
        [DataMember(Order = 1)]
        public byte[] Payload { get; set; }
    }
    
    [DataContract]
    public class DeleteRowsGrpcRequest
    {
        [DataMember(Order = 1)]
        public List<string> Locations { get; set; }
        
        [DataMember(Order = 2)]
        public string TableName { get; set; }
        
        [DataMember(Order = 3)]
        public RowsToDeleteByPartitionGrpc[] RowsToDelete { get; set; }
        
        [DataMember(Order = 4)]
        public SyncGrpcHeader[] Headers { get; set; }
    }

    
    [DataContract]
    public class RowsToDeleteByPartitionGrpc
    {
        [DataMember(Order = 1)]
        public string PartitionKey { get; set; }
        
        [DataMember(Order = 2)]
        public string[] RowKeys { get; set; }
    }


    [DataContract]
    public class DeleteTablePartitionGrpcRequest
    {
        [DataMember(Order = 1)]
        public List<string> Locations { get; set; }
        
        [DataMember(Order = 2)]
        public string TableName { get; set; }
        
        [DataMember(Order = 3)]
        public string[] PartitionKeys { get; set; }
        
        [DataMember(Order = 4)]
        public SyncGrpcHeader[] Headers { get; set; }
    }

    [DataContract]
    public class SetTableAttributesGrpcRequest
    {
        [DataMember(Order = 1)]
        public List<string> Locations { get; set; }
        
        [DataMember(Order = 2)]
        public string TableName { get; set; }
        
        [DataMember(Order = 2)]
        public bool Persist { get; set; }

        [DataMember(Order = 3)]
        public int MaxPartitionsAmount { get; set; }
        
        [DataMember(Order = 4)]
        public SyncGrpcHeader[] Headers { get; set; }
    }
    

    [DataContract]
    public class DownloadTableGrpcRequest
    {
        [DataMember(Order = 1)]
        public string TableName { get; set; }
    }
    

}