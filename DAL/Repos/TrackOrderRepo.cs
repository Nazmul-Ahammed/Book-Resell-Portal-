using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class TrackOrderRepo : Repo, IRepo<TrackOrder, int, TrackOrder>
    {
        public TrackOrder Add(TrackOrder obj)
        {
            db.TrackOrders.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.TrackOrders.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<TrackOrder> Get()
        {
            return db.TrackOrders.ToList();
        }

        public TrackOrder Get(int id)
        {
            return db.TrackOrders.Find(id);
        }

        public TrackOrder Update(TrackOrder obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
