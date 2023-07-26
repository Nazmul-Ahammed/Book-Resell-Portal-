using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductInventoryDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Stock { get; set; }
    }
}
