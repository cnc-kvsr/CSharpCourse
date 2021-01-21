using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }
        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();  //direk veri tabanına sorgulama
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.unitPrice>=price).ToList();  //direk veri tabanına sorgulama
            }
        }

        public List<Product> GetByUnitPrice(decimal min,decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.unitPrice >= min && p.unitPrice<=max).ToList();  //direk veri tabanına sorgulama
            }
        }

        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //var result = context.Products.FirstOrDefault(p => p.Id == id);
                var result = context.Products.SingleOrDefault(p => p.Id == id);
                return result;
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product); //gönderdiğin productı veritabanındaki ile eşitliyor
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product); //gönderdiğin productı veritabanındaki ile eşitliyor
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
