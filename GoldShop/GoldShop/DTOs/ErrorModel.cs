using Newtonsoft.Json;

namespace GoldShop.DTOs
{
    public class ErrorDetails
    {
        public string Message { get; set; }

        public ErrorDetails(string message)
        {
            Message = message;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
