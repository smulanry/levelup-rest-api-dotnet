namespace LevelUpRestApi
{
    public class LevelUpAuthorizationToken
    {
        public string AuthToken {get; set; }
        public string ClientId { get; set; }
        public string Secret { get; set; }

        public LevelUpAuthorizationToken(string clientId, string secret)
        {
            ClientId = clientId;
            Secret = secret;
        }
    }
}
