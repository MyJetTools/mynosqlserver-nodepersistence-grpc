using System.Collections.Generic;
using System.Runtime.Serialization;



namespace MyNoSqlServer.NodePersistence.Grpc
{
    [DataContract]
    public class WriteTableSnapshotGrpcModel
    {
        [DataMember(Order = 1)] public List<string> Locations { get; set; }

        [DataMember(Order = 2)] public string TableName { get; set; }

        [DataMember(Order = 3)] public bool PersistTable { get; set; }

        [DataMember(Order = 4)] public byte[] Content { get; set; }

        [DataMember(Order = 5)] public SyncGrpcHeader[] Headers { get; set; }
    }

    [DataContract]
    public class WritePartitionSnapshotGrpcModel
    {
        [DataMember(Order = 1)] public List<string> Locations { get; set; }

        [DataMember(Order = 2)] public string TableName { get; set; }

        [DataMember(Order = 3)] public string PartitionKey { get; set; }

        [DataMember(Order = 4)] public bool PersistTable { get; set; }

        [DataMember(Order = 5)] public byte[] Content { get; set; }

        [DataMember(Order = 6)] public SyncGrpcHeader[] Headers { get; set; }

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
        [DataMember(Order = 1)] public string TableName { get; set; }

        [DataMember(Order = 2)] public bool Persist { get; set; }

        [DataMember(Order = 3)] public int MaxPartitionsAmount { get; set; }
    }

}
