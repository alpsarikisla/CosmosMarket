using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Product
    {
        public int ID { get; set; }
        public string BarcodeNo { get; set; }
        public string ProductName { get; set; }
        public int Category_ID { get; set; }
        public string Category { get; set; }
        public int Brand_ID { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
