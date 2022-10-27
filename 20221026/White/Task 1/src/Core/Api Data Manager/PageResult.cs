
namespace White.Core
{
    internal class PageResult : IPageResult
    {
        public string TotalResults { get ; set ; }
        public string Response { get ; set ; }
        public List<IResult> Results { get ; set ; }
    }
}
