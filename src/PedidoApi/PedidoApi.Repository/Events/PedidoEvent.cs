using System;
using System.Text.Json;
using Google.Cloud.PubSub.V1;
using Google.Protobuf;
using PedidoApi.Repository.Events.Interfaces;

namespace PedidoApi.Repository.Events
{
    public class PedidoEvent : IPedidoEvent
    {
        public async void EnviarEventoPedidoRecebido(string filePath)
        {
            var topicName = new TopicName("projeto-ganhamo","pedido");
            var message = JsonSerializer.Serialize(filePath);
            var data = ByteString.CopyFromUtf8(message);

            var publisher = await PublisherClient.CreateAsync(topicName);
            var messageId = await publisher.PublishAsync(data);
        }
    }
}