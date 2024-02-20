using Business.Adapter;
using Business.Concrete;
using Entities.Concrete;
using Workspace;

internal class Program
{
    private static void Main(string[] args)
    {
        //Variables()

        Personn person = new Personn();
        person.firstName = "Talha";

        Greet();
        Greet(person.firstName);

        int num1 = 1;
        int num2 = 2;
        Console.WriteLine($"Sum of {num1} and {num2} is {Sum(num1, num2)}");

        // arrays
        string[] categories = new string[3];
        categories[0] = "Home";
        categories[1] = "Computer Parts";
        categories[2] = "Cosmetic";

        for (int i = 0; i < categories.Length; i++)
        {
            Console.WriteLine(categories[i]);
        }

        // reference
        string[] cities1 = new[] { "İstanbul", "Ankara", "İzmir" };
        string[] cities2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

        cities2 = cities1;
        cities1[0] = "Malatya";
        Console.WriteLine(cities2[0]);

        foreach (string city in cities1)
        {
            Console.WriteLine(city);
        }

        // List
        List<string> newCities = new List<string> { "Nevşehir", "New York", "New Delhi" };
        foreach (string city in newCities)
        {
            Console.WriteLine(city);
        }

        // MyList
        MyList<int> myList= new MyList<int> { 1, 2, 3, 4, 5, 6 };
        foreach(var item in myList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("MyList Length: " + myList.Count());


        PttManager pttManager = new PttManager(new CitizenManager(new MernisServiceAdapter()));
        Citizen citizen = new Citizen() { 
            NationalIdentity = 123,
            FirstName = "ALİ",
            LastName = "CENGİZ",
            DateOfBirthYear = 1792
        };

        pttManager.GiveMask(citizen);

        PttManager pttManager2 = new PttManager(new ForeignerManager());
        Foreigner foreigner = new Foreigner()
        {
            FirstName = "George",
            LastName = "Clooney"
        };

        pttManager2.GiveMask(foreigner);
    }

    static void Variables()
    {
        string message = "Hello";
        double sum = 150000;
        int num = 7;
        bool isAuthenticated = false;

        string firstName = "Ali";
        string lastName = "Cengiz";
        int dateOfBirth = 1792;
        long tckn = 12345678910;

        Console.WriteLine(sum * 1.18);
        Console.WriteLine(sum * 1.18);
    }

    class Personn
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int dateOfBirth { get; set; }
        public long tckn { get; set; }
    }

    static void Greet(string name = "User")
    {
        Console.WriteLine("Hi " + name);
    }

    static int Sum(int number1, int number2)
    {
        int sum = number1 + number2;
        return sum;
    }
}

