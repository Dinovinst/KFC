public class StoreInfo 
{
    public static void Main(string[] args)
    {
        StoreInfonation StIn = new StoreInfonation();
        StIn.Registered_Capital = "1,000,000 บาท";
        StIn.Branch_Name = "KFC บางขุนเทียน ชายทะเล";
        StIn.Address = "ถนนชายทะเลบางขุนเทียน ซอย 27";

        PrintCarInformation(StIn);
    }


    static void PrintCarInformation(StoreInfonation storeinfonation)
    {
        Console.WriteLine("Registered Capital: {0}", storeinfonation.Registered_Capital);
        Console.WriteLine("Branch Name: {0}", storeinfonation.Branch_Name);
        Console.WriteLine("Address: {0}", storeinfonation.Address);
    }
}

public class StoreInfonation
{
    public string Registered_Capital;
    public string Branch_Name;
    public string Address;
}