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
    public class SoldItemServices
    {
        public static List<SoldItemDTO> Get()
        {
            var data = DataAccessFactory.SoldItemDataAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Sold_Items, SoldItemDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<SoldItemDTO>>(data);
        }
        public static SoldItemDTO Get(int id)
        {
            var data = DataAccessFactory.SoldItemDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Sold_Items, SoldItemDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<SoldItemDTO>(data);
        }
        public static SoldItemDTO Add(PaymentDTO sold)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SoldItemDTO, Sold_Items>();
                c.CreateMap<Sold_Items, SoldItemDTO>();
            });
            var mapper = new Mapper(cfg);
            var so = mapper.Map<Sold_Items>(sold);
            var data = DataAccessFactory.SoldItemDataAccess().Add(so);

            if (data != null) return mapper.Map<SoldItemDTO>(data);
            return null;
        }
    }
}
