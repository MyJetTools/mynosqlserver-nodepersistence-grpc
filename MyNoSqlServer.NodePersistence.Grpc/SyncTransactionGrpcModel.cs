using System.Collections.Generic;
using System.Runtime.Serialization;

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
    public class SyncTransactionGrpcModel
    {
        
        [DataMember(Order = 1)]
        public string TableName { get; set; }
        
        [DataMember(Order = 2)]
        public SyncGrpcHeader[] Headers { get; set; }
        
        [DataMember(Order = 3)]
        public List<string> Locations { get; set; }
        
        [DataMember(Order = 4)]
        public bool InitPacket { get; set; }
        
        [DataMember(Order = 5)]
        public TableAttributesGrpcData TableAttributes { get; set; }
        
        [DataMember(Order = 6)]
        public List<PartitionDataGrpcModel> InitTableData { get; set; }
        
        [DataMember(Order = 7)]
        public List<PartitionDataGrpcModel> InitPartitionsData { get; set; }
        
        [DataMember(Order = 8)]
        public List<PartitionDataGrpcModel> UpdateRowsData { get; set; }

        [DataMember(Order = 9)]
        public Dictionary<string, string[]> DeleteRows { get; set; }
    }
}