using System;

namespace PedidoApi.Repository.Events.Interfaces
{
    public interface IPedidoEvent
    {
        void EnviarEventoPedidoRecebido(string filePath);
    }
}