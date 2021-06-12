using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace MyNoSqlServer.NodePersistence.Grpc
{
    [ServiceContract(Name = "persistence.MyNoSqlServer")]
    public interface IMyNoSqlServerNodePersistenceGrpcService
    {
        [OperationContract(Action = "Ping")]
        ValueTask PingAsync(PingGrpcRequest request);

        [OperationContract(Action = "SaveTableSnapshot")]
        ValueTask SaveTableSnapshotAsync(IAsyncEnumerable<PayloadWrapperGrpcModel> payloads);
        
        [OperationContract(Action = "SaveTableSnapshotCompressed")]
        ValueTask SaveTableSnapshotCompressedAsync(IAsyncEnumerable<PayloadWrapperGrpcModel> payloads);
        
        [OperationContract(Action = "SavePartitionSnapshot")]
        ValueTask SavePartitionSnapshotAsync(IAsyncEnumerable<PayloadWrapperGrpcModel> payloads);
        
        [OperationContract(Action = "SavePartitionCompressedSnapshot")]
        ValueTask SavePartitionCompressedSnapshotAsync(IAsyncEnumerable<PayloadWrapperGrpcModel> payloads);
        
        [OperationContract(Action = "DeleteTablePartitions")]
        ValueTask DeleteTablePartitionsAsync(DeleteTablePartitionGrpcRequest request);

        [OperationContract(Action = "SetTableAttributes")]
        ValueTask SetTableAttributesAsync(SetTableAttributesGrpcRequest request);

        [OperationContract(Action = "GetTables")]
        IAsyncEnumerable<GetTableGrpcResponse> GetTablesAsync();

        [OperationContract(Action = "DownloadTable")]
        IAsyncEnumerable<TablePartitionGrpcModel> DownloadTableAsync(DownloadTableGrpcRequest request);
        
        [OperationContract(Action = "DownloadTableCompressed")]
        IAsyncEnumerable<TablePartitionGrpcModel> DownloadTableCompressedAsync(DownloadTableGrpcRequest request);

    }
}