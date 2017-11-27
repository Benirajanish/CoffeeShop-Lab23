//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Item
    {
        [Required(ErrorMessage = "Item_id is required")]
        public int Item_id { get; set; }

        [Required(ErrorMessage = "Item_Name is required")]
        public string Item_Name { get; set; }

        
        public string Description { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public string Quantity { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [RegularExpression(@"^\$?\d+(\(\d{2}))?$")]
        public decimal Price { get; set; }
    }
}