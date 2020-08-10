using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio <TEntity> :IDisposable where TEntity : class  //Criando um Repositorio de  nome Base Repositório, irá trabalhar somente com Entity, essa interface herda da inteface IDisposable, este Entituy é um class
    {
        void Adicionar(TEntity entity);
        TEntity ObterId(int id);

        IEnumerable<TEntity> ObterTodos();

        void Atualizar(TEntity entity);

        void Remover(TEntity entity);
            
      
     }
}
