Meneger meneger = new Meneger();
MainPage mainPage = new MainPage();
bosh:
string path = mainPage.Filter();;
var temp = meneger.Search(path);
int k =0;
if(temp.totalResults!=null && temp.totalResults!="")
k = int.Parse(temp.totalResults);
else
System.Console.WriteLine(" Afsuski kino topilmadi ");
if(k % 10 == 0)
k = k / 10;
else
k = k / 10 + 1;
for (int i = 1; i <= k; i++)
{
    Console.Clear();
    temp = meneger.Search(path + "&page=" + i);
    int m = temp.Search.Count;
    for (int j = 0; j < m; j++)
    {
        System.Console.WriteLine(temp.Search[j]);
    }
    System.Console.WriteLine($"<- {i}/{k} ->");
    System.Console.WriteLine(" chiqish uchun Enter");
    char ch = (char)(Console.ReadKey().Key);
    if((int)ch == 13)
    break;
    if((int)ch == 39)
        if(i < k)
        continue;
        else
        i--;
    else if((int)ch == 37)
        if(i > 1)
        i -= 2;
        else
        i--;
    else
        i--;
}
System.Console.WriteLine(" Yana boshqa film qidirib ko'rasizmi? Yes/No");
if('Y' == (char)(Console.ReadKey().Key))
goto bosh;