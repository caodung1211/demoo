//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace baithi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class loai
    {
        public int IDsp { get; set; }
        public string tensp { get; set; }
        public string congdung { get; set; }
    
        public virtual sanpham sanpham { get; set; }
    }
}
