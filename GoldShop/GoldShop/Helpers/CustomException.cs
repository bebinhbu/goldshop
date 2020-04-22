using System;

namespace GoldShop.Helpers
{
    public class CustomException : Exception
    {
        public CustomException(string Message) : base(Message) { }
    }
}
