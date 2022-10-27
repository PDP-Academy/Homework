namespace White.Core;
internal interface Imeneger
{
    ///<Summary>Title bo'yicha qidirib ma'lumotlarni uzatadi</Summary>
    List<IResult> SearchDataByTitle(string title, int page);

    List<IResult> SortDataByType(List<IResult> list);

}