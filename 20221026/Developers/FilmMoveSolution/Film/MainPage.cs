class MainPage
{
    public string s { get; set; } = null; // filmni nomi 
    public string y { get; set; } = null; // filmni yili
    public string i {get; set;} = null; // filmni IMBDmi
    public string type {get; set;} = null;
    public void Inputs()
    {
tittle: 
       // System.Console.Write("Tittle kiritasizmi?   Xa \\ Yoq ");
        string answer = "xa";
        if (answer == "Xa" || answer == "xa")
        {
            System.Console.Write("Tittle: ");
            this.s = Console.ReadLine();
        }
        else if(answer == "Yoq" || answer == "yoq")
        {
        }
        System.Console.WriteLine("Typeni kiritasizmi?   Xa \\ Yoq  ");
        answer = Console.ReadLine();
        if(answer == "xa" || answer == "Xa")
        {
            System.Console.WriteLine("1) movie");
            System.Console.WriteLine("2) series");
            System.Console.WriteLine("3) episodes");
            System.Console.WriteLine("4) game");

            System.Console.Write("Typini raqam bilan kiriting: ");
            int input = int.Parse(Console.ReadLine());
boshidan:   switch(input)
            {
                case 1:
                    type = "movie";
                    break;
                case 2:
                    type = "series";
                    break;
                case 3:
                    type = "episodes";
                    break;
                case 4:
                    type = "game";
                    break;
                default:
                    System.Console.WriteLine("Xato boshidan kriting");
                    goto boshidan;
                    break;
            }


        }

//         System.Console.Write("Yilni kiritasizmi?  Xa \\ Yoq ");
//         answer = Console.ReadLine();
//         }
//         else
//         {
//             System.Console.WriteLine("Xa yoki Yoq kiriting!");
//             Console.Clear();
//             Thread.Sleep(1500);
//             System.Console.WriteLine("Boshidan kiriting!");
//             goto tittle;
//         }
//  Yil1:      
//         if(answer == "Xa" || answer == "xa")
//         {
//             System.Console.Write("Yil: ");
//             this.y = Console.ReadLine();
//         }
//         else if(answer == "Yoq" || answer == "yoq")
//         {

//         }
//         else 
//         {
//              System.Console.WriteLine("Xa yoki Yoq kiriting!");
//             Console.Clear();
//             Thread.Sleep(1500);
//             System.Console.WriteLine("Boshidan kiriting!");
//             System.Console.Write("Javob:       Xa \\ Yoq");
//             answer = Console.ReadLine();
//             goto Yil1;
//         }
        
}
    public string Filter()
    {
        Inputs();
        string str = "";
            str = str + "&" + $"s={s}";
        if(type != null)
            str = str + "&" + $"type={type}";
        // if(y != null)
        //     str = str + "&" + $"y={y}";
        // if(i != null)
        //     str = str + "&" + $"i={i}";

        return str;
    }

       

}
    

