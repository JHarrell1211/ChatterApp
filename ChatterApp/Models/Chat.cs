//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatterApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chat
    {
        public int ChatID { get; set; }
        public string ChatMessage { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public string UserID { get; set; }
    }
}
