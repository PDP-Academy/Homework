namespace White.Core;
internal interface Imeneger
{
    ///<Summary>Title bo'yicha qidirib ma'lumotlarni uzatadi</Summary>
    List<Movie> SearchDataByTitle(string title, int page);

    List<Movie> SortDataByType(List<Movie> list);

}