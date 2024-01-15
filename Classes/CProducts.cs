using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOne.Clases
{
    class CProducts
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Products { get; set; }
        public decimal Quantity { get; set; }

        public CProducts(int code, string name, string products, decimal quantity)
        {
            Code = code;
            Name = name;
            Products = products;
            Quantity = quantity;
        }
    }
}
