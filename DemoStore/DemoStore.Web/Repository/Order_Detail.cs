//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoStore.Web.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Detail
    {
        public string Id { get; set; }
        public string Order_Id { get; set; }
        public int Quantity { get; set; }
        public string Product_Id { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}