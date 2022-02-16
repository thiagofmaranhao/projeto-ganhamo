using System;
using PedidoApi.Business.Models;

namespace PedidoApi.Business.Services.Interfaces
{
    public interface IPedidoService
    {
        Guid RegistrarPedidoRecebido(Pedido pedido);
    }
}