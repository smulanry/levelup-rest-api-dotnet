using System;
using System.Collections.Generic;
using System.Linq;
using LevelUpRestApi.ResponseObjects;
using RestSharp;

namespace LevelUpRestApi
{
    public class Location
    {
        public Location()
        {
            Categories = new List<int>();
        }

        public List<int> Categories { get; set; }

        public long Id { get; set; }
        
        public decimal? Latitude { get; set; }
        
        public decimal? Longitude { get; set; }

        public long MerchantId { get; set; }

        public string MerchantName { get; set; }

        public bool Shown { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public static IList<Location> All(LevelUpAuthorizationToken authorizationToken, int? pageNumber = null)
        {
            return new LevelUpApiClient().Execute<List<LocationResponse>>(ResourceUrls.Locations(), Method.GET).Select(x => x.Location).ToList();
        }

        public static IList<Location> FindByApplicationId(LevelUpAuthorizationToken authorizationToken, int applicationId)
        {
            return new LevelUpApiClient().Execute<List<LocationResponse>>(ResourceUrls.ApplicationLocations(applicationId), Method.GET).Select(x => x.Location).ToList();
        }

        public static Location Get(LevelUpAuthorizationToken authorizationToken, int locationId)
        {
            return new LevelUpApiClient().Execute<LocationResponse>(ResourceUrls.Locations(locationId), Method.GET);
        }
    }
}