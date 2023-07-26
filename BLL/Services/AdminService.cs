using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminService
    {
        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminDataAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<AdminDTO>>(data);
        }

        public static AdminDTO Get(int id)
        {
            var data = DataAccessFactory.AdminDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<AdminDTO>(data);
        }
        public static AdminDTO Add(AdminDTO reg)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<AdminDTO, Admin>();
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var re = mapper.Map<Admin>(reg);
            var data = DataAccessFactory.AdminDataAccess().Add(re);

            if (data != null) return mapper.Map<AdminDTO>(data);
            return null;
        }

        public static AdminDTO Update(AdminDTO div)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<AdminDTO, Admin>();
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Admin>(div);
            var data = DataAccessFactory.AdminDataAccess().Update(ht);

            if (data != null) return mapper.Map<AdminDTO>(data);
            return null;
        }
        
        public static bool Delete(int id)
        {
            var data = DataAccessFactory.AdminDataAccess().Delete(id);
            if (data != false) return true;
            return false;
        }

    }
}
