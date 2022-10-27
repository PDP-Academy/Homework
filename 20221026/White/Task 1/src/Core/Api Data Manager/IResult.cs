namespace White.Core;
internal interface IResult
{
    public string Title { get; set; }
    public string Message { get; set; }
    public string ImdbId { get; set; }
    public string Type { get; set; }
    public string Poster { get; set; }
}

