namespace White.Core;

internal class ApiDataManager : IApiDataManager
{

    // /<Summary>O'zida API uchun key saqlaydi</Summary>
    private string ApiKey { get; }

    ///<Summary>API URL base</Summary>
    private string ApiUrl { get => "http://img.omdbapi.com/"; }

    public List<object> GetDataFromApi()
    {
        throw new NotImplementedException();
    }
}