using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Management.ViewModel
{
    public class RoomViewModel
    {
        public int RoomId { get; set; }

        [Display(Name = "Room No.")]
        [Required(ErrorMessage = "Room number is requird.")]
        public string RoomNumber { get; set; }

        [Display(Name = "Room Image")]
        public string RoomImage { get; set; }

        [Display(Name = "Room Price")]
        [Required(ErrorMessage = "Room price is requird.")]
        [Range(500,10000, ErrorMessage = "Room price should be equal or greater than {1}")]
        public decimal RoomPrice { get; set; }

        [Display(Name = "Booking Status")]
        [Required(ErrorMessage = "Booking status is requird.")]
        public int BookingStatusId { get; set; }

        [Display(Name = "Room Type")]
        [Required(ErrorMessage = "Room type is requird.")]
        public int RoomTypeId { get; set; }

        [Display(Name = "Room Capacity")]
        [Required(ErrorMessage = "Room capacity is requird.")]
        [Range(1,8,ErrorMessage = "Room capacity should be equal or greater than {1}")]
        public int RoomCapacity { get; set; }

        public HttpPostedFileBase Image { get; set; }

        [Display(Name = "Room Description")]
        [Required(ErrorMessage = "Room description is requird.")]
        public string RoomDescription { get; set; }

        public List<SelectListItem> ListOfBookingStatus { get; set; }

        public List<SelectListItem> ListOfRoomType { get; set; }

    }
}