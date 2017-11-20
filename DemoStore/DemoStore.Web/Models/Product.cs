using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoStore.Web.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Number { get; set; }
        public string Tittle { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Category category { get; set; }
    }
}