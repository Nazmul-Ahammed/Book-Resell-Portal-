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
    public class ProductInventoryServices
    {
        public static List<ProductInventoryDTO> Get()
        {
            var data = DataAccessFactory.ProductInventoryDataAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ProductInventory, ProductInventoryDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<ProductInventoryDTO>>(data);
        }
        public static ProductInventoryDTO Get(int id)
        {
            var data = DataAccessFactory.ProductInventoryDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductInventory, ProductInventoryDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<ProductInventoryDTO>(data);
        }
        public static ProductInventoryDTO Add(ProductInventoryDTO pro)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ProductInventoryDTO, ProductInventory>();
                c.CreateMap<ProductInventory, ProductInventoryDTO>();
            });
            var mapper = new Mapper(cfg);
            var pi = mapper.Map<ProductInventory>(pro);
            var data = DataAccessFactory.ProductInventoryDataAccess().Add(pi);

            if (data != null) return mapper.Map<ProductInventoryDTO>(data);
            return null;
        }
    }
}
