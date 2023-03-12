using System;

namespace WepApiCRUD.Models
{
    public class Product
    {
        public int id { get; set; }        
        public string? name { get; set; }
        public string? descripction { get; set; }
        public DateTime created { get; set; }
        public Decimal price { get; set; }
        public bool isActive { get; set; }


    }
}
