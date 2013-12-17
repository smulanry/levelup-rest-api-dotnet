namespace LevelUpRestApi.ResponseObjects
{
    /// <summary>
    /// Response object required by the location api
    /// </summary>
    internal class LocationResponse
    {
        public Location Location { get; set; }

        public static implicit operator Location(LocationResponse lr)
        {
            return lr != null ? lr.Location : null;
        }
    }
}
