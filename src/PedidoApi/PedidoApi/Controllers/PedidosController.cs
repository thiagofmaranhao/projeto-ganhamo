using System;
using Microsoft.AspNetCore.Mvc;
using PedidoApi.Request;
using PedidoApi.Response;

namespace PedidoApi.Controllers
{
    [ApiController]
    [Route("pedidos")]
    public class PedidosController : ControllerBase
    {
        [HttpPost]
        public ActionResult<PedidoResponse> CriarPedido(PedidoRequest request)
        {
            var response = new PedidoResponse {Id = Guid.NewGuid()};

            return Created("", response);
        }
    }
}