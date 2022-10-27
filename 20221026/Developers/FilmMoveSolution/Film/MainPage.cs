class MainPage
{
    public MainPage(string t, string y, string i)
    {
        this.t = t;
        this.y = y;
        this.i = i;
    }
    public string t { get; set; } = null;
    public string y { get; set; } = null;
    public string i {get; set;} = null;
    
    public void Inputs()
    {
        System.Console.Write("Tittle kiritasizmi?   Xa \\ Yoq ");
        string answer = Console.ReadLine();
        if (answer == "Xa" || answer == "xa")
        {
            System.Console.Write("Tittle: ");
            this.t = Console.ReadLine();
        }
        else
        System.Console.Write("Yilni kiritasizmi?  Xa \\ Yoq ");
        answer = Console.ReadLine();
        if(answer == "Xa" || answer == "xa")
        {
            System.Console.Write("Yil: ");
            this.y = Console.ReadLine();
        }
        else if(answer == "Yoq" )
        {
        System.Console.Write("Rating kiritasizmi? Xa \\ Yoq ");
        answer = Console.ReadLine();
        }
        if(answer == "Xa" || answer == "xa")
        {
            System.Console.Write("Rating: ");
            this.i = Console.ReadLine();
        }
        else
            System.Console.WriteLine(""); /// ERTAGA OZIM DAVOM ETAMAN SAHAR BOMDODGA 8:00dan

    
    }


}
    

