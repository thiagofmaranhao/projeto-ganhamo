using System;
using PedidoApi.Business.Models;
using PedidoApi.Business.Services.Interfaces;

namespace PedidoApi.Business.Services
{
    public class PedidoService : IPedidoService
    {
        public Guid RegistrarPedidoRecebido(Pedido pedido)
        {
            // TODO: implement RegistrarPedidoRecebido
            return pedido.Id;
        }
    }
}