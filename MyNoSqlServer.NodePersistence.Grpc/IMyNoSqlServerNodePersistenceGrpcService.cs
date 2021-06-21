using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace MyNoSqlServer.NodePersistence.Grpc
{
    [ServiceContract(Name = "persistence.MyNoSqlServer")]
    public interface IMyNoSqlServerNodePersistenceGrpcService
    {
        [OperationContract(Action = "Ping")]
        ValueTask<PingGrpcResponse> PingAsync(PingGrpcRequest request);

        [OperationContract(Action = "SyncTransactions")]
        ValueTask SyncTransactionsAsync(IAsyncEnumerable<PayloadWrapperGrpcModel> payloads);
        
        [OperationContract(Action = "SyncTransactions")]
        ValueTask SyncTransactionsCompressedAsync(IAsyncEnumerable<PayloadWrapperGrpcModel> payloads);

        [OperationContract(Action = "GetTables")]
        IAsyncEnumerable<ReadTableAttributeGrpcModel> GetTablesAsync();

        [OperationContract(Action = "DownloadTable")]
        IAsyncEnumerable<ReadTablePartitionGrpcModel> DownloadTableAsync(DownloadTableGrpcRequest request);
        
        [OperationContract(Action = "DownloadTableCompressed")]
        IAsyncEnumerable<ReadTablePartitionGrpcModel> DownloadTableCompressedAsync(DownloadTableGrpcRequest request);

    }
}