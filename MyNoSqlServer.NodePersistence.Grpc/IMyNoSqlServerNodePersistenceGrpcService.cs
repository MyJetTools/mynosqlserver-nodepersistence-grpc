﻿using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace MyNoSqlServer.NodePersistence.Grpc
{
    [ServiceContract(Name = "persistence.MyNoSqlServer")]
    public interface IMyNoSqlServerNodePersistenceGrpcService
    {
        [OperationContract(Action = "Ping")]
        ValueTask<PingGrpcResponse> PingAsync(PingGrpcRequest request);

        [OperationContract(Action = "SaveTableSnapshot")]
        ValueTask SaveTableSnapshotAsync(IAsyncEnumerable<PayloadWrapperGrpcModel> payloads);
        
        [OperationContract(Action = "SaveTableSnapshotCompressed")]
        ValueTask SaveTableSnapshotCompressedAsync(IAsyncEnumerable<PayloadWrapperGrpcModel> payloads);
        
        [OperationContract(Action = "SavePartitionSnapshot")]
        ValueTask SavePartitionSnapshotAsync(IAsyncEnumerable<PayloadWrapperGrpcModel> payloads);
        
        [OperationContract(Action = "SavePartitionCompressedSnapshot")]
        ValueTask SavePartitionCompressedSnapshotAsync(IAsyncEnumerable<PayloadWrapperGrpcModel> payloads);
        
        [OperationContract(Action = "SaveRowsSnapshot")]
        ValueTask SaveRowsSnapshotAsync(IAsyncEnumerable<PayloadWrapperGrpcModel> payloads);
        
        [OperationContract(Action = "SaveRowsCompressedSnapshot")]
        ValueTask SaveRowsCompressedSnapshotAsync(IAsyncEnumerable<PayloadWrapperGrpcModel> payloads);
        
        
        [OperationContract(Action = "DeleteRows")]
        ValueTask DeleteRowsAsync(IAsyncEnumerable<PayloadWrapperGrpcModel> payloads);

        
        [OperationContract(Action = "DeleteTablePartitions")]
        ValueTask DeleteTablePartitionsAsync(DeleteTablePartitionGrpcRequest request);

        [OperationContract(Action = "SetTableAttributes")]
        ValueTask SetTableAttributesAsync(SetTableAttributesGrpcRequest request);

        [OperationContract(Action = "GetTables")]
        IAsyncEnumerable<ReadTableAttributeGrpcModel> GetTablesAsync();

        [OperationContract(Action = "DownloadTable")]
        IAsyncEnumerable<ReadTablePartitionGrpcModel> DownloadTableAsync(DownloadTableGrpcRequest request);
        
        [OperationContract(Action = "DownloadTableCompressed")]
        IAsyncEnumerable<ReadTablePartitionGrpcModel> DownloadTableCompressedAsync(DownloadTableGrpcRequest request);

    }
}