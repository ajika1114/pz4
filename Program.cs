using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person { FirstName = "Іван", LastName = "Петров", Birthday = new DateTime(2003, 5, 15) },
            new Person { FirstName = "Марія", LastName = "Сидорова", Birthday = new DateTime(2005, 8, 22) },
            new Person { FirstName = "Олександр", LastName = "Іванов", Birthday = new DateTime(1999, 12, 31) }
        };

        var selectedPeople = people.Where(p => p.Birthday.Year > 2000)
                                   .OrderBy(p => p.LastName)
                                   .ThenBy(p => p.FirstName);

        foreach (var person in selectedPeople)
        {
            Console.WriteLine($"{person.LastName} {person.FirstName}");
        }
    }
}

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }
}
