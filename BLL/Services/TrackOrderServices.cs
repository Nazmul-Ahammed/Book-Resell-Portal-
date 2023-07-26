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
    public class TrackOrderServices
    {
        public static List<TrackOrderDTO> Get()
        {
            var data = DataAccessFactory.TrackOrderDataAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<TrackOrder, TrackOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<TrackOrderDTO>>(data);
        }
        public static TrackOrderDTO Get(int id)
        {
            var data = DataAccessFactory.TrackOrderDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Product, ProductDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<TrackOrderDTO>(data);
        }
        public static TrackOrderDTO Add(TrackOrderDTO pro)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<TrackOrderDTO, TrackOrder>();
                c.CreateMap<TrackOrder, TrackOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var pr = mapper.Map<TrackOrder>(pro);
            var data = DataAccessFactory.TrackOrderDataAccess().Add(pr);

            if (data != null) return mapper.Map<TrackOrderDTO>(data);
            return null;
        }

        public static TrackOrderDTO Update(TrackOrderDTO div)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<TrackOrderDTO, TrackOrder>();
                c.CreateMap<TrackOrder, TrackOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<TrackOrder>(div);
            var data = DataAccessFactory.TrackOrderDataAccess().Update(ht);

            if (data != null) return mapper.Map<TrackOrderDTO>(data);
            return null;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.TrackOrderDataAccess().Delete(id);
            if (data != false) return true;
            return false;
        }
    }
}
