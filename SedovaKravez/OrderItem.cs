//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SedovaKravez
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItem
    {
        public int IdOrder { get; set; }
        public int Service { get; set; }
        public Nullable<int> MedicalSupplies { get; set; }
        public short Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    
        public virtual MedicalSupplies MedicalSupplies1 { get; set; }
        public virtual Order Order { get; set; }
        public virtual Service Service1 { get; set; }
    }
}