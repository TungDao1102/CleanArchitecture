﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.WebUI.Models.ViewModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CleanArchitecture.WebUI.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public string UserId { get; set; }
     //   public AppUser? AppUser { get; set; }

        public int VillaId { get; set; }
        public Villa? Villa { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public double TotalCost { get; set; }
        public int Nights { get; set; }
        public string Status { get; set; }

        public DateTime BookingDate { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }

        public bool IsPaymentSuccessful { get; set; } = false;
        public DateTime PaymentDate { get; set; }

        public string? StripeSessionId { get; set; }
        public string? StripePaymentIntentId { get; set; }

        public DateTime ActualCheckInDate { get; set; }
        public DateTime ActualCheckOutDate { get; set; }

        public int VillaNumber { get; set; }
        [ValidateNever]
        public ICollection<VillaNumber>? VillaNumbers { get; set; }
    }
}
