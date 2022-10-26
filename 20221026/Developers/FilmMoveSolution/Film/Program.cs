Meneger meneger = new Meneger();
Console.WriteLine(meneger.Search(""));



static void SHow(List<string> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine(list[i]);
        if (i + 1 % 10 == 0)
        {
            Console.WriteLine("<- Oraqaga || Oldinga ->");
            int key = (int)Console.ReadKey().Key;
            if (key == 39 && i != list.Count - 1)
            {
                continue;
            }
            else if (key == 37 && i != 0)
            {
                i -= 10;
            }
        }
    }
}