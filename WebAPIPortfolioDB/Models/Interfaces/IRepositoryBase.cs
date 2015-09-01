using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIPortfolioDB.Models.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        List<TEntity> Listar();

        TEntity Buscar(int id);

        void Update(TEntity obj);

        void Delete(TEntity obj);
    }
}
