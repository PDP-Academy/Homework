namespace White.Core;
internal interface Imeneger
{
    ///<Summary>Title bo'yicha qidirib ma'lumotlarni uzatadi</Summary>
    public List<Object> SearchDataByTitle(string title, int page);

    public List<IResult> SortDataByType(List<IResult> list);

}