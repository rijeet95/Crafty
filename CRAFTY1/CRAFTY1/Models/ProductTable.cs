//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRAFTY1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductTable()
        {
            this.OrderTables = new HashSet<OrderTable>();
        }
    
        public int P_ID { get; set; }
        public string Product_Name { get; set; }
        public byte[] Product_Image { get; set; }
        public string Product_Price { get; set; }
        public string Product_Descriptation { get; set; }
        public string Categories { get; set; }
        public int Product_Stock { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderTable> OrderTables { get; set; }
    }
}
