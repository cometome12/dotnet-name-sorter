using System.Collections.Generic;
using System;
using System.Linq;

public class PersonList
{
    public List<Person> people { get; set; }

    public PersonList()
    {
        this.people = new List<Person>();
    }

    public void add(Person person)
    {
        try {
            this.people.Add(person);
        } catch (Exception e) {
            Console.WriteLine("Something went wrong when mapping the person. Message: "+ e.Message);
            Environment.Exit(1);
        }
    }

    public void sortByLastNameAndGivenNames()
    {
        this.people = this.people
        .OrderBy(person => person.lastName)
        .ThenBy(person=>person.givenName[0])
        .ThenBy(person=>person.givenName.Length >= 2 ? person.givenName[1] : string.Empty)
        .ThenBy(person=>person.givenName.Length >= 3 ? person.givenName[2] : string.Empty)
        .ToList();


        

    }

    public string[] getFullNameArray()
    {
        return this.people.Select( person => person.fullName).ToArray();
    }

    public string getFullNameStr()
    {
        return String.Join(System.Environment.NewLine, getFullNameArray());
    }

    public void displayAllNames()
    {
        foreach (Person person in this.people)
        {
            Console.WriteLine(person.fullName);
        }
    }
}