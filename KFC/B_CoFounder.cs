public class CoFounder 
{
    public static void Main(string[] args)
    {
        CoFounderInfonation CoFoInOne = new CoFounderInfonation();
        CoFoInOne.Name = "นายทวี";
        CoFoInOne.Surname = "ใจดีดี";
        CoFoInOne.ID_Card_Code = "153-698-4561237";

        CoFounderInfonation CoFoInTwo = new CoFounderInfonation();
        CoFoInTwo.Name = "นายยุทธดี";
        CoFoInTwo.Surname = "ตั้งใจเรียน";
        CoFoInTwo.ID_Card_Code = "742-112-5687412";

        CoFounderInfonation CoFoInThree = new CoFounderInfonation();
        CoFoInThree.Name = "นายเจมส์";
        CoFoInThree.Surname = "รักโรงเรียน";
        CoFoInThree.ID_Card_Code = "541-772-3215689";

        PrintCarInformation(CoFoInOne);
        PrintCarInformation(CoFoInTwo);
        PrintCarInformation(CoFoInThree);
    }


    static void PrintCarInformation(CoFounderInfonation cofounderinfonation)
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("Name: {0}", cofounderinfonation.Name);
        Console.WriteLine("Surname: {0}", cofounderinfonation.Surname);
        Console.WriteLine("ID Card Code: {0}", cofounderinfonation.ID_Card_Code);
        Console.WriteLine("*********************************");
    }
}

public class CoFounderInfonation
{
    public string Name;
    public string Surname;
    public string ID_Card_Code;
}