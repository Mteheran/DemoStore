using DemoStore.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoStore.Web.Models
{
    public class ProductViewModel
    {
        public List<string>  CategoryId { get; set; }
        public Product Product_obj { get; set; }
    }
}