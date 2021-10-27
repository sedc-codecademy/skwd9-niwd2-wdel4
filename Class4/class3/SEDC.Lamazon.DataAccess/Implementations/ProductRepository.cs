using SEDC.Lamazon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Lamazon.DataAccess.Implementations
{
    public class ProductRepository : IRepository<Product>
    {
        public void DeleteById(int id)
        {
            //check if a record with the given id exists
            Product product = StaticDb.Products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                throw new Exception($"Product with id {id} was not found");
            }
            //delete record from DB
            int index = StaticDb.Products.IndexOf(product);
            StaticDb.Products.RemoveAt(index);
        }

        public List<Product> GetAll()
        {
            //return domain models (all records from the table in DB)
            return StaticDb.Products;
        }

        public Product GetById(int id)
        {
            //returns one record from a table in DB (by id)
            return StaticDb.Products.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Product entity)
        {
            //increment the id
            StaticDb.ProductId++;
            entity.Id = StaticDb.ProductId;
            //send the record to the DB
            StaticDb.Products.Add(entity);
            return entity.Id;
        }

        public void Update(Product entity)
        {
            //check if the record with the id of the updated entity exists
            Product product = StaticDb.Products.FirstOrDefault(x => x.Id == entity.Id);
            if (product == null)
            {
                throw new Exception($"Product with id {entity.Id} was not found");
            }
            //update the record in DB
            int index = StaticDb.Products.IndexOf(product);
            StaticDb.Products[index] = entity;
        }
    }
}
