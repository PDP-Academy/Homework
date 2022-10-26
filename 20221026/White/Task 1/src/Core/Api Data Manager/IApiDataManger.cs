namespace White.Core;

internal interface IApiDataManager
{
    ///<Summary>O'zida API uchun key saqlaydi</Summary>
    public string ApiKey { get; }
    ///<Summary>Apidan ma'lumot olib beradi</Summary>
    public List<Object> GetDataFromApi(string url);
    ///<Summary>Title bo'yicha qidirib ma'lumotlarni uzatadi</Summary>
    public List<Object> SearchDataByTitle(string title);
}