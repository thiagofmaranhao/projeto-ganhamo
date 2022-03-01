using System.Threading.Tasks;
using PedidoApi.Domain;

namespace PedidoApi.Repository.Interfaces
{
    public interface IPedidoRepository
    {
        Task<string> Add(Pedido pedido);
    }
}