

namespace White.Core
{
    public class Movie : IResult
    {
        public string Title { get; set; }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ImdbId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Poster { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
