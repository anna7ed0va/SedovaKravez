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
    
    public partial class Client
    {
        public int IdClient { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }
        public int Pets { get; set; }
    
        public virtual Gender Gender1 { get; set; }
        public virtual MedCard MedCard { get; set; }
    }
}