using PedidoApi.Domain;

namespace PedidoApi.Business.Services.Interfaces
{
    public interface IPedidoService
    {
        void RegistrarPedidoRecebido(Pedido pedido);
    }
}