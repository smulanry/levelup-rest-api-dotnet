using System;
using RestSharp;

namespace LevelUpRestApi
{
    /// <summary>
    /// Client used to collect data from the level up service
    /// </summary>
    internal class LevelUpApiClient
    {
        public static LevelUpApiVersion DefaultVersion = LevelUpApiVersion.V14;

        private readonly RestClient _client;

        public LevelUpApiClient()
        {
            _client = new RestClient(String.Format("https://api.thelevelup.com/{0}", DefaultVersion.ToString().ToLowerInvariant()));
        }

        public T Execute<T>(string resource, Method method) where T : new()
        {
            var response = _client.Execute<T>(new RestRequest(resource, method));
            
            if (response.ResponseStatus != ResponseStatus.Completed || response.ErrorException != null)
                throw new LevelUpApiException(
                      "Api response status: " + response.ResponseStatus + " - HTTP response: " + response.StatusCode + " - " + response.StatusDescription
                    + " - " + response.Content);

            return response.Data;
        }
    }
}
