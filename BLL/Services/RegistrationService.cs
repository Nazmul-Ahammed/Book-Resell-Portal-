using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RegistrationService
    {
        public static List<RegistrationDTO> Get()
        {
            var data = DataAccessFactory.RegistrationDataAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Registration, RegistrationDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<RegistrationDTO>>(data);
        }
        public static RegistrationDTO Get(int id)
        {
            var data = DataAccessFactory.RegistrationDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Registration, RegistrationDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<RegistrationDTO>(data);
        }
        public static RegistrationDTO Add(RegistrationDTO reg)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<RegistrationDTO, Registration>();
                c.CreateMap<Registration, RegistrationDTO>();
            });
            var mapper = new Mapper(cfg);
            var re = mapper.Map<Registration>(reg);
            var data = DataAccessFactory.RegistrationDataAccess().Add(re);

            if (data != null) return mapper.Map<RegistrationDTO>(data);
            return null;
        }
    }
}
