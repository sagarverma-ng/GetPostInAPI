//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testdelete.DbConnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public product()
        {
            this.productSets = new HashSet<productSet>();
        }
    
        public int id { get; set; }
        public string nameData { get; set; }
    
        public virtual ICollection<productSet> productSets { get; set; }
    }
}
