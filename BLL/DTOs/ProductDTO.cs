using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookCondition { get; set; }
        public string Category { get; set; }
        public string Book_details { get; set; }
        public string Author_Name { get; set; }
        public int SellerID { get; set; }
    }
}
