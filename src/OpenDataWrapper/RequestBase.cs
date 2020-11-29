namespace OpenDataWrapper
{
    public class RequestBase
    {
        public string RepresentationType { get; private set; }
        public string[] StationTypes { get; private set; }
        public int Offset { get; private set; }
        public int Limit { get; private set; }

        public static RequestBase Create(string representationType, string[] stationTypes, int offset = 0, int limit = 200)
        {
            return new RequestBase
            {
                RepresentationType = representationType,
                StationTypes = stationTypes,
                Offset = offset,
                Limit = limit
            };
        }
    }
}
