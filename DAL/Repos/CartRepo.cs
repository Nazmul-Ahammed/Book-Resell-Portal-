using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CartRepo : Repo, IRepo<Cart, int, Cart>
    {
        public Cart Add(Cart obj)
        {
            db.Carts.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Carts.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Cart> Get()
        {
            return db.Carts.ToList();
        }

        public Cart Get(int id)
        {
            return db.Carts.Find(id);
        }

        public Cart Update(Cart obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
