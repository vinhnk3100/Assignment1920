//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Computer_Shop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailsOrderProductsOrder
    {
        public int DetailsOrderID { get; set; }
        public int Product_ID { get; set; }
        public int Quantity { get; set; }
        public string Product_Name { get; set; }
        public double Price { get; set; }
        public int OrderID { get; set; }
        public string Image1 { get; set; }
    }
}