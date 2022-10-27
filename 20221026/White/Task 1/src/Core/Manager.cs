namespace White.Core;

class Manager : Imeneger
{
    IApiDataManager manager = new ApiDataManager();
    public List<Movie> SearchDataByTitle(string title, int page)
    {
        List<Movie> list = manager.SearchDataByTitle(title, page);
        return SortDataByType(list);

    }
    public List<Movie> SortDataByType(List<Movie> list)
    {
        List<Movie> temp = new List<Movie>();
        foreach (var item in list)
        {
            if (item.Type == "movie")
            {
                temp.Add(item);
            }
        }

        foreach (var item in list)
        {
            if (item.Type == "series")
            {
                temp.Add(item);
            }
        }

        foreach (var item in list)
        {
            if (item.Type == "episode")
            {
                temp.Add(item);
            }
        }

        return temp;
    }
}