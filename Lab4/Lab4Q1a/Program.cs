internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Distance in miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        double kilometers = miles * 1.609;
        Console.WriteLine($"{miles} miles is {kilometers} kilometers");
        Console.ReadKey();
    }
}