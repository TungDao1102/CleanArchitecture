﻿namespace CleanArchitecture.WebUI.Utilities
{
    public class Constants
    {
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
        public enum ContentType
        {
            Json,
            MultipartFormData,
        }
        public static string APIUrlBase { get; set; }
        public const string TokenCookie = "JWTToken";
        public const string RefreshToken = "RefreshToken";
        public const string RefreshTokenExpires = "RefreshTokenExpires";

        public const string StatusPending = "Pending";
        public const string StatusApproved = "Approved";
        public const string StatusCheckedIn = "CheckedIn";
        public const string StatusCompleted = "Completed";
        public const string StatusCancelled = "Cancelled";
        public const string StatusRefunded = "Refunded";

        public const string Role_Customer = "CUSTOMER";
        public const string Role_Admin = "ADMIN";
        public const string Role_User = "USER";
        public const string Role_Manager = "MANAGER";
    }
}
