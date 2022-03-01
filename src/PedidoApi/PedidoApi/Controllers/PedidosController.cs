using System;
using Microsoft.AspNetCore.Mvc;
using PedidoApi.Business.Services.Interfaces;
using PedidoApi.Mappings;
using PedidoApi.Request;
using PedidoApi.Response;

namespace PedidoApi.Controllers
{
    [ApiController]
    [Route("pedidos")]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;
        
        public PedidosController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }
        
        [HttpPost]
        public ActionResult<PedidoResponse> CriarPedido(PedidoRequest request)
        {
            // TODO: Adicionar validação do Request

            var pedido = Mapping.PedidoRequestToPedido(request);

            _pedidoService.RegistrarPedidoRecebido(pedido);
            
            var response = new PedidoResponse {Id = pedido.Id};

            return Accepted("", response);
        }
    }
}