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
    public class ProductService
    {
        public static List<ProductDTO> Get()
        {
            var data = DataAccessFactory.ProductDataAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Product, ProductDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<ProductDTO>>(data);
        }
        public static ProductDTO Get(int id)
        {
            var data = DataAccessFactory.ProductDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Product, ProductDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<ProductDTO>(data);
        }
        public static ProductDTO Add(ProductDTO pro)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ProductDTO, Product>();
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var pr = mapper.Map<Product>(pro);
            var data = DataAccessFactory.ProductDataAccess().Add(pr);

            if (data != null) return mapper.Map<ProductDTO>(data);
            return null;
        }
    }
}
