//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QA_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeDemand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeDemand()
        {
            this.DemandDescriptions = new HashSet<DemandDescription>();
        }
    
        public int Id { get; set; }
        public string TymeName { get; set; }
        public int GroupDemandId { get; set; }
    
        public virtual GroupDemand GroupDemand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DemandDescription> DemandDescriptions { get; set; }
    }
}
