//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuilderWebSite.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class OurServiceImages
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public string Alt { get; set; }
        public string Title { get; set; }
        public long OurServiceId { get; set; }
    
        public virtual OurServices OurServices { get; set; }
    }
}