namespace GoldShop.DTOs
{
    public class TokenModel
    {
        public string AccessToken { get; set; }
        public TokenModel() { }
        public TokenModel(string token)
        {
            AccessToken = token;
        }
    }
}
