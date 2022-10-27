class MainPage
{
    public MainPage(string s, string y, string i)
    {
        this.s = s;
        this.y = y;
        this.i = i;
    }
    public string s { get; set; } = null;
    public string y { get; set; } = null;
    public string i {get; set;} = null;
    
    public void Inputs()
    {
tittle: 
        System.Console.Write("Tittle kiritasizmi?   Xa \\ Yoq ");
        string answer = Console.ReadLine();
        if (answer == "Xa" || answer == "xa")
        {
            System.Console.Write("Tittle: ");
            this.s = Console.ReadLine();
        }
        else if(answer == "Yoq" || answer == "yoq")
        {
        System.Console.Write("Yilni kiritasizmi?  Xa \\ Yoq ");
        answer = Console.ReadLine();
        }
        else
        {
            System.Console.WriteLine("Xa yoki Yoq kiriting!");
            Console.Clear();
            Thread.Sleep(1500);
            System.Console.WriteLine("Boshidan kiriting!");
            goto tittle;
        }
 Yil1:      
        if(answer == "Xa" || answer == "xa")
        {
            System.Console.Write("Yil: ");
            this.y = Console.ReadLine();
        }
        else if(answer == "Yoq" || answer == "yoq" )
        {
        System.Console.Write("Rating kiritasizmi? Xa \\ Yoq ");
        answer = Console.ReadLine();
        }
        else
        {
             System.Console.WriteLine("Xa yoki Yoq kiriting!");
            Console.Clear();
            Thread.Sleep(1500);
            System.Console.WriteLine("Boshidan kiriting!");
            System.Console.Write("Javob:       Xa \\ Yoq");
            answer = Console.ReadLine();
            goto Yil1;
        }
        if(answer == "Xa" || answer == "xa")
        {
            System.Console.Write("Rating: ");
            this.i = Console.ReadLine();
        }
        else
            System.Console.WriteLine("Kuting..."); /// ERTAGA OZIM DAVOM ETAMAN SAHAR BOMDODGA 8:00dan
    }
    public string Filter()
    {
        return $"s={s}&y={y}&i={i}";
    }

       

}
    

