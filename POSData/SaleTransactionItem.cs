//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSData
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaleTransactionItem
    {
        public int SaleTransactionItemId { get; set; }
        public int SaleTransactionId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual SaleTransaction SaleTransaction { get; set; }
    }
}
