//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Skripsi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tn_m_manufacture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tn_m_manufacture()
        {
            this.tn_m_equipment = new HashSet<tn_m_equipment>();
        }
    
        public int m_manu_id { get; set; }
        public string m_manu_code { get; set; }
        public string m_manu_name { get; set; }
        public string status { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tn_m_equipment> tn_m_equipment { get; set; }
    }
}
