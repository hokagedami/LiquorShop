using System;
using System.Collections.Generic;
using System.Text;

namespace LiqourShop.Data.Models
{
    public class Shop
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public User Owner { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
