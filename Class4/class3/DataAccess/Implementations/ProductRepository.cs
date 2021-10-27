using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Implementations
{
    public class ProductRepository : IRepository<Product>
    {
        public void DeleteById(int id)
        {
            Product product = StaticDb.Products.FirstOrDefault(x => x.Id == id);
            if(product == null)
            {
                throw new Exception($"Product with id {id} was not found");
            }

            int index = StaticDb.Products.IndexOf(product);
            StaticDb.Products.RemoveAt(index);
        }

        public List<Product> GetAll()
        {
            return StaticDb.Products;
        }

        public Product GetById(int id)
        {
            return StaticDb.Products.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Product entity)
        {
            StaticDb.ProductId++;
            entity.Id = StaticDb.ProductId;
            StaticDb.Products.Add(entity);
            return entity.Id;
        }

        public void Update(Product entity)
        {
            Product product = StaticDb.Products.FirstOrDefault(x => x.Id == entity.Id);
            if(product == null)
            {
                throw new Exception($"Product with id {entity.Id} was not fout");
            }

            int index = StaticDb.Products.IndexOf(product);
            StaticDb.Products[index] = entity;
        }
    }
}
