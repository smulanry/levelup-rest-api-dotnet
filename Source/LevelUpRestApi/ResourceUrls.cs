using System.Globalization;
using System.IO;

namespace LevelUpRestApi
{
    /// <summary>
    /// Generates the urls for the various resources
    /// </summary>
    internal static class ResourceUrls
    {
        public static string ApplicationLocations(int applicationId)
        {
            return Url("apps", applicationId.ToString(), "locations");
        }

        public static string Locations()
        {
            return Url("locations");
        }

        public static string Locations(long id)
        {
            return Url("locations", id.ToString(CultureInfo.InvariantCulture));
        }

        static string Url(params string[] components)
        {
            return Path.Combine(components);
        }
    }
}
