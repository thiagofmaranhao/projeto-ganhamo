using System;
using System.Collections.Generic;

namespace PedidoApi.Request
{
    public class PedidoRequest
    {
        public ClienteRequest Cliente { get; set; }
        
        public EnderecoRequest EnderecoEntrega { get; set; }
        
        public List<ItemPedidoRequest> ItensPedido { get; set; }
        
        public DadosPagamentoRequest DadosPagamento { get; set; }
        
        public decimal ValorTotal { get; set; }
    }

    public class ClienteRequest
    {
        public Guid Id { get; set; }
        
        public string Nome { get; set; }
    }

    public class EnderecoRequest
    {
        public string Cep { get; set; }
        
        public string Estado { get; set; }
        
        public string Cidade { get; set; }
        
        public string Bairro { get; set; }
        
        public string Rua { get; set; }
        
        public string Numero { get; set; }
    }

    public class ItemPedidoRequest
    {
        public Guid Id { get; set; }
        
        public string Nome { get; set; }
        
        public int Quantidade { get; set; }
        
        public int Valor { get; set; }
    }

    public class DadosPagamentoRequest
    {
        public string NumeroCartao { get; set; }
        
        public string Cvc { get; set; }
        
        public int MesValidade { get; set; }
        
        public int AnoValidade { get; set; }
        
        public string NomeTitularCartao { get; set; }
        
        public int QuantidadeParcelas { get; set; }
    }
}