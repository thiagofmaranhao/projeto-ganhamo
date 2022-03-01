using PedidoApi.Business.Services.Interfaces;
using PedidoApi.Domain;
using PedidoApi.Repository.Events.Interfaces;
using PedidoApi.Repository.Interfaces;

namespace PedidoApi.Business.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoEvent _pedidoEvent;
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoEvent pedidoEvent, IPedidoRepository pedidoRepository)
        {
            _pedidoEvent = pedidoEvent;
            _pedidoRepository = pedidoRepository;
        }

        public async void  RegistrarPedidoRecebido(Pedido pedido)
        {
            var filePath = await _pedidoRepository.Add(pedido);
            
            _pedidoEvent.EnviarEventoPedidoRecebido(filePath);
        }
    }
}