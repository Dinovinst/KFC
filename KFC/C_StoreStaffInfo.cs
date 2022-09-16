public class StoreStaffInfo 
{
    public static void Main(string[] args)
    {
        StoreStaffInfonation StStInOne = new StoreStaffInfonation();
        StStInOne.Staff_Position = "พนักงานประจำร้าน";
        StStInOne.Name = "นาย ชัยดี";
        StStInOne.Surname = "รักดี";
        StStInOne.Age = "20";
        StStInOne.Salary = "15,000";

        StoreStaffInfonation StStInTwo = new StoreStaffInfonation();
        StStInTwo.Staff_Position = "พนักงานประจำร้าน";
        StStInTwo.Name = "นาย นอนดี";
        StStInTwo.Surname = "ใจดี";
        StStInTwo.Age = "18";
        StStInTwo.Salary = "15,000";

        StoreStaffInfonation StStInThree = new StoreStaffInfonation();
        StStInThree.Staff_Position = "พนักงานประจำร้าน";
        StStInThree.Name = "นาย อภัยดี";
        StStInThree.Surname = "เรียนดี";
        StStInThree.Age = "22";
        StStInThree.Salary = "15,000";

        StoreStaffInfonation StStInFour = new StoreStaffInfonation();
        StStInFour.Staff_Position = "พนักงานส่งอาหาร";
        StStInFour.Name = "นาย ทำดี";
        StStInFour.Surname = "งานดี";
        StStInFour.Age = "25";
        StStInFour.Salary = "12,500";

        StoreStaffInfonation StStInFive = new StoreStaffInfonation();
        StStInFive.Staff_Position = "พนักงานส่งอาหาร";
        StStInFive.Name = "นาย นอนดี";
        StStInFive.Surname = "เรียบดี";
        StStInFive.Age = "23";
        StStInFive.Salary = "12,500";

        PrintCarInformation(StStInOne);
        PrintCarInformation(StStInTwo);
        PrintCarInformation(StStInThree);
        PrintCarInformation(StStInFour);
        PrintCarInformation(StStInFive);
    }

    static void PrintCarInformation(StoreStaffInfonation storestaffinfonation)
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("Staff Position: {0}", storestaffinfonation.Staff_Position);
        Console.WriteLine("Name: {0}", storestaffinfonation.Name);
        Console.WriteLine("Surname: {0}", storestaffinfonation.Surname);
        Console.WriteLine("Age: {0}", storestaffinfonation.Age);
        Console.WriteLine("Salary: {0}", storestaffinfonation.Salary);
        Console.WriteLine("*********************************");
    }
}

public class StoreStaffInfonation
{
    public string Staff_Position;
    public string Name;
    public string Surname;
    public string Age;
    public string Salary;
}