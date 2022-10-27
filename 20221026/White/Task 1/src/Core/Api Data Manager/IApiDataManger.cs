namespace White.Core;

internal interface IApiDataManager
{
<<<<<<< HEAD
    public List<Object> SearchDataByTitle(string title);
    
=======
    /// <summary>
    /// Title bo'yicha qidirish
    /// </summary>
    /// <param name="title">qidirish uchun kalit so'z</param>
    /// <param name="page">qidiriligan malumotni pagei </param>
    /// <returns></returns>
    public List<Object> SearchDataByTitle(string title, int page);
>>>>>>> 2479a8243f495477f772aabcdbb2afc6e921669c
}