using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetosdeValor
{
   public  class FormaPagamento
    {
        public int Id { get; set; }

        public int Nome { get; set; }

        public string Descricao { get; set; }

        public bool EhBoleto {
            get { return Id == (int)TiposFormaPagamentoEnum.Boleto; }
       
        }
        public bool EhCartaoCredito
        {
            get { return Id == (int)TiposFormaPagamentoEnum.CartaoCredito; }

        }

        public bool NãofoiDefinido
        {
            get { return Id == (int)TiposFormaPagamentoEnum.NaoDefinido; }

        }
        

    }
}
