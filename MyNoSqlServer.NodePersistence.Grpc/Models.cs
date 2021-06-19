using System.Collections.Generic;
using System.Runtime.Serialization;



namespace MyNoSqlServer.NodePersistence.Grpc
{
    [DataContract]
    public class WriteTableSnapshotGrpcModel
    {
        [DataMember(Order = 1)] 
        public string TableName { get; set; }
        
        [DataMember(Order = 2)] 
        public List<string> Locations { get; set; }
        
        [DataMember(Order = 3)] 
        public TableAttributesGrpcData Attributes { get; set; }

        [DataMember(Order = 4)] 
        public byte[] TableSnapshot { get; set; }

        [DataMember(Order = 5)] 
        public SyncGrpcHeader[] Headers { get; set; }
    }

    [DataContract]
    public class WritePartitionSnapshotGrpcModel
    {
        [DataMember(Order = 1)] 
        public string TableName { get; set; }
        
        [DataMember(Order = 2)] 
        public List<string> Locations { get; set; }

        [DataMember(Order = 3)] 
        public SyncGrpcHeader[] Headers { get; set; }
        
        [DataMember(Order = 4)] 
        public byte[] PartitionsToBeInitialized { get; set; }


    }
    
    [DataContract]
    public class WriteRowsUpdateGrpcModel
    {
        [DataMember(Order = 1)] 
        public List<string> Locations { get; set; }

        [DataMember(Order = 2)] 
        public string TableName { get; set; }

        [DataMember(Order = 3)] 
        public byte[] RowsContent { get; set; }

        [DataMember(Order = 4)] 
        public SyncGrpcHeader[] Headers { get; set; }
    }

    [DataContract]
    public class ReadTablePartitionGrpcModel
    {
        [DataMember(Order = 2)] 
        public string PartitionKey { get; set; }

        [DataMember(Order = 3)] 
        public byte[] Content { get; set; }

        [DataMember(Order = 4)] 
        public SyncGrpcHeader[] Headers { get; set; }
    }

    [DataContract]
    public class ReadTableAttributeGrpcModel
    {
        [DataMember(Order = 1)] 
        public string TableName { get; set; }

        [DataMember(Order = 2)] 
        public TableAttributesGrpcData Attributes { get; set; }

    }
    
    [DataContract]
    public class TableAttributesGrpcData
    {
        [DataMember(Order = 1)] 
        public bool Persist { get; set; }

        [DataMember(Order = 2)] 
        public int MaxPartitionsAmount { get; set; }  
    }


    [DataContract]
    public class PartitionDataGrpcModel
    {
        [DataMember(Order = 1)] 
        public string PartitionKey { get; set; }
        
        [DataMember(Order = 2)] 
        public byte[] Snapshot { get; set; }
    }

}
