using QuickBuy.Dominio.ObjetosdeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
   public class Pedido
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }
        public int UsuarioID { get; set; }

        public ICollection<ItemPedido> ItensPedido  { get; set; }  //Pedido deve  ter pelo menos um Item dpedido ou muitos Itens de pedidos.

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }
        public string Estado { get; set; }

        public string 
           Cidade{ get; set; }

        public int EnderecoCompleto { get; set; }

        public int FormaPagamentoId { get; set; }

        public FormaPagamento FormaPagamento { get; set; }


    }
}
