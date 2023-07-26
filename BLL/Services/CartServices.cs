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
    public class CartServices
    {
        public static List<CartDTO> Get()
        {
            var data = DataAccessFactory.CartDataAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Cart, CartDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<CartDTO>>(data);
        }
        public static CartDTO Get(int id)
        {
            var data = DataAccessFactory.CartDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Cart, CartDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<CartDTO>(data);
        }
        public static CartDTO Add(CartDTO car)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<CartDTO, Cart>();
                c.CreateMap<Cart, CartDTO>();
            });
            var mapper = new Mapper(cfg);
            var cr = mapper.Map<Cart>(car);
            var data = DataAccessFactory.CartDataAccess().Add(cr);

            if (data != null) return mapper.Map<CartDTO>(data);
            return null;
        }
    }
}
