//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnThi
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPro
    {
        public int ProID { get; set; }
        public string ProName { get; set; }
        public Nullable<int> ProStatus { get; set; }
        public string ProDescription { get; set; }
        public Nullable<int> CatID { get; set; }
    
        public virtual tblCat tblCat { get; set; }
    }
}
