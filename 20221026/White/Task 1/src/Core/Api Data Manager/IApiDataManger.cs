namespace White.Core;

internal interface IApiDataManager
{
    /// <summary>
    /// Title bo'yicha qidirish
    /// </summary>
    /// <param name="title">qidirish uchun kalit so'z</param>
    /// <param name="page">qidiriligan malumotni pagei </param>
    /// <returns></returns>
    public List<IResult> SearchDataByTitle(string title, int page);
}