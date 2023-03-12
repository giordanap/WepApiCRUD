using System;

namespace WepApiCRUD.Models
{
    public class User
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? email { get; set; }
        public DateTime created { get; set; }
        public bool isActive { get; set; }
    }
}
