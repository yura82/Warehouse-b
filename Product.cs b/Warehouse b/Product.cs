//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warehouse_b
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Naam { get; set; }
        public Nullable<int> Inkoopprijse { get; set; }
        public Nullable<long> Marge { get; set; }
        public Nullable<int> Eenheid { get; set; }
        public Nullable<long> BTW { get; set; }
        public Nullable<int> LeveranciersId { get; set; }
        public Nullable<int> CategorieId { get; set; }
    }
}