namespace src
{
    public class Program
    {
       static void Main(string[] args)
    {
        SortedDictionary<string, string> Directory = new SortedDictionary<string, string>();
        Console.WriteLine("Enter the Number of inputs");
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter the Name : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Year : ");
            string year = Console.ReadLine();
            Directory.Add(year , Name);
        }
        Console.WriteLine("Press key to display the contents of your dictionary..");
        Console.ReadLine();
        foreach (var item in Directory)
        {
            Console.WriteLine("year : " + item.Key);
            Console.WriteLine("Name : " + item.Value);
        }
        Console.ReadLine();
        Console.WriteLine("Enter the Year : ");
        string a = Console.ReadLine();

        
        
            foreach (var item1 in Directory)
        {
            if (a == item1.Key)
            {
            Console.WriteLine("year : " + item1.Key);
            Console.WriteLine("Name : " + item1.Value);
            }
            else 
            {
                System.Console.WriteLine("pm not found...");
                break;
            }
        }
           
           
        
    }

    }
}




