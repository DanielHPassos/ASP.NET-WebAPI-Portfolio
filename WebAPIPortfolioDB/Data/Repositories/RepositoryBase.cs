using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIPortfolioDB.Data.Context;
using WebAPIPortfolioDB.Models.Interfaces;

namespace WebAPIPortfolioDB.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity :class 
    {
        protected Contexto ctx = new Contexto();
        public void Add(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
            ctx.SaveChanges();
        }

        public List<TEntity> Listar()
        {
            return ctx.Set<TEntity>().ToList();

        }

        public TEntity Buscar(int id)
        {
            return ctx.Set<TEntity>().Find(id);
        }

        public void Update(TEntity obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            ctx.Set<TEntity>().Remove(obj);
        }
    }
}
