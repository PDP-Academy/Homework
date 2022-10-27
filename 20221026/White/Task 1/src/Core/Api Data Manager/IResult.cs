namespace White.Core;
internal interface IResult
{
    /// <summary>
    /// Movie title
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Movie chiqqan yili
    /// </summary>
    public string Year { get; set; }
    /// <summary>
    /// Movie Idsi
    /// </summary>
    public string ImdbId { get; set; }
    /// <summary>
    /// Movi turi
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Movie Posteri
    /// </summary>
    public string Poster { get; set; }

}