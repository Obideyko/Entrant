//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntrantApps
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entrant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Entrant()
        {
            this.Certificate = new HashSet<Certificate>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Place_of_birth { get; set; }
        public string Passport { get; set; }
        public string Whem_and_by_whom_issued { get; set; }
        public string Place_of_residence { get; set; }
        public string SNILS { get; set; }
        public string Medical_policy { get; set; }
        public Nullable<int> ID_Certificate { get; set; }
        public string Telephone { get; set; }
        public int ID_Specialization { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Certificate> Certificate { get; set; }
        public virtual Certificate Certificate1 { get; set; }
        public virtual Specialization Specialization { get; set; }
    }
}
