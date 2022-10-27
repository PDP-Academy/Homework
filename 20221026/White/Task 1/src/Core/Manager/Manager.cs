using White.Core;

internal class Manager
{
    IApiDataManager manager;
    public Manager(IApiDataManager manager)
    {
        this.manager = manager;
    }

    public List<IMovie> SearchByTitle(string title, int pageNumber)
    {
        return OrderByType(manager.SearchDataByTitle(title, pageNumber));
    }

    public List<IMovie> OrderByType(List<IMovie> list)
    {
        return list.OrderBy(x => x.Type).ToList();
    }
}