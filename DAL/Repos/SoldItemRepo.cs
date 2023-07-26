using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SoldItemRepo : Repo, IRepo<Sold_Items, int, Sold_Items>
    {
        public Sold_Items Add(Sold_Items obj)
        {
            db.Sold_Items.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Sold_Items.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Sold_Items> Get()
        {
            return db.Sold_Items.ToList();
        }

        public Sold_Items Get(int id)
        {
            return db.Sold_Items.Find(id);
        }

        public Sold_Items Update(Sold_Items obj)
        {
            throw new NotImplementedException();
        }
    }
}
