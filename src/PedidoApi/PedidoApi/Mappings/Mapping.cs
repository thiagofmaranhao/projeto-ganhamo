using System.Linq;
using PedidoApi.Domain;
using PedidoApi.Request;

namespace PedidoApi.Mappings
{
    public static class Mapping
    {
        public static Pedido PedidoRequestToPedido(PedidoRequest pedidoRequest)
        {
            return new Pedido
            {
                Cliente = new Cliente
                {
                    Id = pedidoRequest.Cliente.Id,
                    Nome = pedidoRequest.Cliente.Nome
                },
                DadosPagamento = new DadosPagamento
                {
                    Cvc = pedidoRequest.DadosPagamento.Cvc,
                    AnoValidade = pedidoRequest.DadosPagamento.AnoValidade,
                    MesValidade = pedidoRequest.DadosPagamento.MesValidade,
                    NumeroCartao = pedidoRequest.DadosPagamento.NumeroCartao,
                    QuantidadeParcelas = pedidoRequest.DadosPagamento.QuantidadeParcelas,
                    NomeTitularCartao = pedidoRequest.DadosPagamento.NomeTitularCartao
                },
                EnderecoEntrega = new Endereco
                {
                    Bairro = pedidoRequest.EnderecoEntrega.Bairro,
                    Cep = pedidoRequest.EnderecoEntrega.Cep,
                    Cidade = pedidoRequest.EnderecoEntrega.Cidade,
                    Estado = pedidoRequest.EnderecoEntrega.Estado,
                    Numero = pedidoRequest.EnderecoEntrega.Numero,
                    Rua = pedidoRequest.EnderecoEntrega.Rua
                },
                ItensPedido = pedidoRequest.ItensPedido
                    .Select(itemPedidoRequest => 
                        new ItemPedido
                        {
                            Id = itemPedidoRequest.Id,
                            Nome = itemPedidoRequest.Nome,
                            Quantidade = itemPedidoRequest.Quantidade,
                            Valor = itemPedidoRequest.Valor
                        }).ToList(),
                ValorTotal = pedidoRequest.ItensPedido.Sum(ip => ip.Valor)
            };
        }
    }
}