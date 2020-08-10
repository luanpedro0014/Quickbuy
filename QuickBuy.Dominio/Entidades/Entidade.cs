using System.Collections.Generic;
using System.Linq;
using System.Net.Security;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
      
      private  List<string> mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); } // GEt propriedade somente de Leitura(Return para verificar se a mensagem está vazia)
        }

        protected void LimparMensagemValidacao() {

            mensagemValidacao.Clear();
        
        }



        protected void AdicionarCritica(string mensagem)
        {

            mensagemValidacao.Add(mensagem);

        }
        public abstract void Validate();
        protected bool EhValido {

            get { return !mensagemValidacao.Any(); }
       
        }


    }
}
