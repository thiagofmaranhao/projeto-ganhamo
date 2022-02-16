using System;
using System.Collections.Generic;

namespace PedidoApi.Business.Models
{
    public class Pedido : Entity
    {
        public Cliente Cliente { get; set; }
        
        public Endereco EnderecoEntrega { get; set; }
        
        public List<ItemPedido> ItensPedido { get; set; }
        
        public DadosPagamento DadosPagamento { get; set; }
        
        public decimal ValorTotal { get; set; }
    }

    public class Cliente
    {
        public Guid Id { get; set; }
        
        public string Nome { get; set; }
    }

    public class Endereco
    {
        public string Cep { get; set; }
        
        public string Estado { get; set; }
        
        public string Cidade { get; set; }
        
        public string Bairro { get; set; }
        
        public string Rua { get; set; }
        
        public string Numero { get; set; }
    }

    public class ItemPedido
    {
        public Guid Id { get; set; }
        
        public string Nome { get; set; }
        
        public int Quantidade { get; set; }
        
        public int Valor { get; set; }
    }

    public class DadosPagamento
    {
        public string NumeroCartao { get; set; }
        
        public string Cvc { get; set; }
        
        public int MesValidade { get; set; }
        
        public int AnoValidade { get; set; }
        
        public string NomeTitularCartao { get; set; }
        
        public int QuantidadeParcelas { get; set; }
    }
}