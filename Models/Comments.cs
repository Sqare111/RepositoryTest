//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication19.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comments
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ClinicID { get; set; }
        public string description { get; set; }
    
        public virtual Clinic Clinic { get; set; }
    }
}