﻿namespace CleanArchitecture.ApplicationCore.Commons
{
    public class PaymentResponse
    {
        public string? StripeSessionUrl { get; set; }
        public string? StripeSessionId { get; set; }
        public string? PaymentIntentId { get; set; }
    }
}
