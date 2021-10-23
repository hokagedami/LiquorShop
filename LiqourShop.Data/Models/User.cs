using System;
using System.Collections.Generic;
using System.Text;

namespace LiqourShop.Data.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string Role { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
