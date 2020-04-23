using System;
using System.Net;

namespace GoldShop.Helpers
{
    public class CustomException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }
        public CustomException(string message) : base(message) { }
        public CustomException(HttpStatusCode statusCode, string message): base(message) => StatusCode = statusCode;
    }
}
