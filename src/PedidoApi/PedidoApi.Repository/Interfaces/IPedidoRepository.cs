using PedidoApi.Business.Models;

namespace PedidoApi.Repository.Interfaces
{
    public interface IPedidoRepository
    {
        void Add(Pedido pedido);
    }
}