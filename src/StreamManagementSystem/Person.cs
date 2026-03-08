public class Person
{
    // 1. PRIVATE ATTRIBUTES (No underscores)
    private string firstName;
    private string lastName;
    private int age;
    private bool isStudent;

    private static string filePath = "database.txt";
    private const char Delimiter = ';';

    // 2. CONSTRUCTOR (Using 'this' keyword)
    public Person(string firstName, string lastName, int age, bool isStudent)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.isStudent = isStudent;
    }

    // 3. GETTER METHODS
    public string GetFullName()
    {
        return this.firstName + " " + this.lastName;
    }

    public int GetAge()
    {
        return this.age;
    }

    // 4. STREAM PERSISTENCE LOGIC

    private string ToDataLine()
    {
        return this.firstName + Delimiter + 
                this.lastName + Delimiter + 
                this.age + Delimiter + 
                this.isStudent;
    }

    public void Save()
    {
        try
        {
            // Open stream in Append mode (true)
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(this.ToDataLine());
            }
        }
        catch (IOException exception)
        {
            Console.WriteLine("Disk Error: " + exception.Message);
        }
    }

    public static List<Person> GetAll()
    {
        List<Person> peopleList = new List<Person>();

        if (!File.Exists(filePath))
        {
            return peopleList;
        }

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string? currentLine;
                // Read line by line until end of stream
                while ((currentLine = reader.ReadLine()) != null)
                {
                    string[] dataParts = currentLine.Split(Delimiter);
                    if (dataParts.Length == 4)
                    {
                        Person personInstance = new Person(
                            dataParts[0], 
                            dataParts[1], 
                            int.Parse(dataParts[2]), 
                            bool.Parse(dataParts[3])
                        );
                        peopleList.Add(personInstance);
                    }
                }
            }
        }
        catch (IOException exception)
        {
            Console.WriteLine("Read Error: " + exception.Message);
        }

        return peopleList;
    }

    public static bool Update(string searchName, string newLastName, int newAge, bool newStatus)
    {
        List<Person> allPeople = Person.GetAll();
        bool isRecordFound = false;

        foreach (Person person in allPeople)
        {
            if (person.firstName.Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                person.lastName = newLastName;
                person.age = newAge;
                person.isStudent = newStatus;
                isRecordFound = true;
                break;
            }
        }

        if (isRecordFound)
        {
            // Overwrite the file (append: false) to reflect updates
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (Person person in allPeople)
                {
                    writer.WriteLine(person.ToDataLine());
                }
            }
        }

        return isRecordFound;
    }
}
