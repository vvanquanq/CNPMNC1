//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDienThoaiDiDong.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DONMUASP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONMUASP()
        {
            this.CHITIETDONMUAs = new HashSet<CHITIETDONMUA>();
        }
    
        public int MaDonMua { get; set; }
        public Nullable<int> MaKH { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public Nullable<decimal> TriGia { get; set; }
        public string TenNguoiMua { get; set; }
        public string Payments { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONMUA> CHITIETDONMUAs { get; set; }
    }
}
