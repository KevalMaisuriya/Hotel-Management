//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoomBooking
    {
        public int BookingId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public System.DateTime BookingFrom { get; set; }
        public System.DateTime BookingTo { get; set; }
        public int AssignRoomId { get; set; }
        public int NoOfMembers { get; set; }
        public decimal TotalAmount { get; set; }
        public string CustomerPhone { get; set; }
    }
}
