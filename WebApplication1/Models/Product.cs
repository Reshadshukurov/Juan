using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public int DiscountPercent { get; set; }
        public string Subtitle { get; set; }


    }
}
