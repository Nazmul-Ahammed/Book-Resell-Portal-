using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TrackOrderDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string OrderDate { get; set; }
        public string ArrivalDate { get; set; }
        public string Status { get; set; }
    }
}
