using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Google.Cloud.Storage.V1;
using PedidoApi.Domain;
using PedidoApi.Repository.Interfaces;

namespace PedidoApi.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        public async Task<string> Add(Pedido pedido)
        {
            const string bucketName = "pedido";
            
            var storage = await StorageClient.CreateAsync();

            var receivable = JsonSerializer.Serialize(pedido);
            var filePath = $"{DateTime.UtcNow:yyyyMMdd}/{pedido.Id}.jsonl";
            var memoryStream = new MemoryStream();
            var textWriter = new StreamWriter(memoryStream) {AutoFlush = true};
            await textWriter.WriteLineAsync(receivable);
            await storage.UploadObjectAsync(bucketName, filePath, "text/plain", (Stream) memoryStream);

            return filePath;
        }
    }
}