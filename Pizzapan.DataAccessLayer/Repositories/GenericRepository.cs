using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T entity)
        {
            using (var context=new PizzapanContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context=new PizzapanContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public T Get(int id)
        {
            using (var context = new PizzapanContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public List<T> GetAll()
        {
            using (var context = new PizzapanContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public void Update(T entity)
        {
            using (var context = new PizzapanContext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
