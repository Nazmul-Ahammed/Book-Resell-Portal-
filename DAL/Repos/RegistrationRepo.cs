using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class RegistrationRepo : Repo, IRepo<Registration, int, Registration>
    {
        public Registration Add(Registration obj)
        {
            db.Registrations.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj=Get(id);
            db.Registrations.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Registration> Get()
        {
            return db.Registrations.ToList();
        }

        public Registration Get(int id)
        {
            return db.Registrations.Find(id);
        }

        public Registration Update(Registration obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if(db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
