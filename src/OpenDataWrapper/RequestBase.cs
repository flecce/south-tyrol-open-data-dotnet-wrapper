namespace OpenDataWrapper
{
    public abstract class RequestBase
    {
        public string Url { get; set; }
        public int Offset { get; set; } = 0;
        public int Limit { get; set; } = 200;
    }
}
