//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhotoOps.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public long EventId { get; set; }
        public string EventName { get; set; }
        public string EventDesc { get; set; }
        public Nullable<System.DateTime> EventDate { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> EventTime { get; set; }
        public byte[] CoverPhoto { get; set; }
    }
}
