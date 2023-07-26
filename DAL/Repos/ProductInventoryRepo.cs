using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ProductInventoryRepo : Repo, IRepo<ProductInventory, int, ProductInventory>
    {
        public ProductInventory Add(ProductInventory obj)
        {
            db.ProductInventories.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.ProductInventories.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<ProductInventory> Get()
        {
            return db.ProductInventories.ToList();
        }

        public ProductInventory Get(int id)
        {
            return db.ProductInventories.Find(id);
        }

        public ProductInventory Update(ProductInventory obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
