class MainPage
{
    public string s { get; set; } = null; // filmni nomi 
    public string y { get; set; } = null; // filmni yili
    public string i {get; set;} = null; // filmni IMBDmi
    
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
        // if(y != null)
        //     str = str + "&" + $"y={y}";
        // if(i != null)
        //     str = str + "&" + $"i={i}";

        return str;
    }

       

}
    

