using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PaymentDTO
    {
        public int Id { get; set; }
        public string Payment_type { get; set; }
        public string Destination { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}
