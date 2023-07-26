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
    public class PaymentServices
    {
        public static List<PaymentDTO> Get()
        {
            var data = DataAccessFactory.PaymentDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Payment, PaymentDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<PaymentDTO>>(data);
        }
        public static PaymentDTO Get(int id)
        {
            var data = DataAccessFactory.PaymentDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Payment, PaymentDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<PaymentDTO>(data);
        }
        public static PaymentDTO Add(PaymentDTO pay)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PaymentDTO, Payment>();
                c.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(cfg);
            var py = mapper.Map<Payment>(pay);
            var data = DataAccessFactory.PaymentDataAccess().Add(py);

            if (data != null) return mapper.Map<PaymentDTO>(data);
            return null;
        }
    }
}
