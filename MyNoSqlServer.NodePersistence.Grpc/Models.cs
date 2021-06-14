using System.Runtime.Serialization;



namespace MyNoSqlServer.NodePersistence.Grpc
{
    [DataContract]
    public class SaveTableSnapshotGrpcModel
    {
        [DataMember(Order = 1)] public string Location { get; set; }

        [DataMember(Order = 2)] public string TableName { get; set; }

        [DataMember(Order = 3)] public bool PersistTable { get; set; }

        [DataMember(Order = 4)] public byte[] Content { get; set; }

        [DataMember(Order = 5)] public SyncGrpcHeader[] Headers { get; set; }
    }

    [DataContract]
    public class SavePartitionSnapshotGrpcModel
    {
        [DataMember(Order = 1)] public string Location { get; set; }

        [DataMember(Order = 2)] public string TableName { get; set; }

        [DataMember(Order = 3)] public string PartitionKey { get; set; }

        [DataMember(Order = 4)] public bool PersistTable { get; set; }

        [DataMember(Order = 5)] public byte[] Content { get; set; }

        [DataMember(Order = 6)] public SyncGrpcHeader[] Headers { get; set; }

    }

    [DataContract]
    public class TablePartitionGrpcModel
    {
        [DataMember(Order = 1)] public string PartitionKey { get; set; }

        [DataMember(Order = 2)] public byte[] Content { get; set; }

        [DataMember(Order = 3)] public SyncGrpcHeader[] Headers { get; set; }

    }

    [DataContract]
    public class TableAttributeGrpcModel
    {
        [DataMember(Order = 1)] public string TableName { get; set; }

        [DataMember(Order = 2)] public bool Persist { get; set; }

        [DataMember(Order = 3)] public int MaxPartitionsAmount { get; set; }
    }

}
