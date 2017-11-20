using DemoStore.Web.Repository;
using System.Collections.Generic;

namespace DemoStore.Web.Models
{
    public class ProductViewModel
    {
        public List<string>  CategoryId { get; set; }
        public Product Product_obj { get; set; }
    }
}