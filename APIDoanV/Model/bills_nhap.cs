//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class bills_nhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bills_nhap()
        {
            this.bill_detail_nhap = new HashSet<bill_detail_nhap>();
        }
    
        public string id { get; set; }
        public string id_ncc { get; set; }
        public string id_nhanvien { get; set; }
        public Nullable<System.DateTime> date_order { get; set; }
        public Nullable<double> tong_tien { get; set; }
        public string thanh_toan { get; set; }
        public string note { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bill_detail_nhap> bill_detail_nhap { get; set; }
    }
}