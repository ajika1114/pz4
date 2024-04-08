using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person { FirstName = "Леся", LastName = "Українка", Birthday = new DateTime(2005, 2, 25) },
            new Person { FirstName = "Тарас", LastName = "Шевченко", Birthday = new DateTime(1814, 3, 9) },
            new Person { FirstName = "Іван", LastName = "Франко", Birthday = new DateTime(2001, 8, 27) },
            new Person { FirstName = "Леонід", LastName = "Каденюк", Birthday = new DateTime(1951, 1, 28) },
            new Person { FirstName = "Сергій", LastName = "Корольов", Birthday = new DateTime(2007, 1, 12) },
            new Person { FirstName = "Василь", LastName = "Стус", Birthday = new DateTime(1938, 1, 8) },
            new Person { FirstName = "Леонід", LastName = "Брежнєв", Birthday = new DateTime(2006, 12, 19) },
            new Person { FirstName = "Анатолій", LastName = "Солов'яненко", Birthday = new DateTime(1932, 9, 8) },
            new Person { FirstName = "Леся", LastName = "Курбас", Birthday = new DateTime(2023, 1, 25) },
            new Person { FirstName = "Пантелеймон", LastName = "Куліш", Birthday = new DateTime(1819, 3, 5) }
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
