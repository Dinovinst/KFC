public class StoreAccout
{
    public static void Main(string[] args)
    {
        StoreAccoutInfonation StAcIn = new StoreAccoutInfonation();
        StAcIn.Monthly_Income = "236,154 Baht";
        StAcIn.Staff_Payroll = "213,069.551 Baht";
        StAcIn.Balance = "23,084.449 Baht";

        PrintCarInformation(StAcIn);
    }


    static void PrintCarInformation(StoreAccoutInfonation storeaccoutinfonation)
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("Monthly Income: {0}", storeaccoutinfonation.Monthly_Income);
        Console.WriteLine("Staff Payroll: {0}", storeaccoutinfonation.Staff_Payroll);
        Console.WriteLine("Balance: {0}", storeaccoutinfonation.Balance);
        Console.WriteLine("*********************************");
    }
}

public class StoreAccoutInfonation
{
    public string Monthly_Income;
    public string Staff_Payroll;
    public string Balance;
}