class Program
{
    static void Main()
    {
        Console.WriteLine("=== STREAM-BASED MANAGEMENT (STRICT) ===");

        // 1. Create and Save
        Person p1 = new Person("Linus", "Torvalds", 56, false);
        p1.Save();

        Person p2 = new Person("Guido", "van Rossum", 70, false);
        p2.Save();

        // 2. List data
        PrintPeople();

        // 3. Update data
        Console.WriteLine("\n> Updating Linus...");
        Person.Update("Linus", "Torvalds (Git Creator)", 57, true);

        // 4. Show updated data
        PrintPeople();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void PrintPeople()
    {
        List<Person> data = Person.GetAll();
        Console.WriteLine("\n--- Records in Database ---");
        foreach (Person p in data)
        {
            Console.WriteLine("Full Name: " + p.GetFullName() + ", Age: " + p.GetAge());
        }
    }
}