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

    public List<Person> sortByLastNameAndGivenNames()
    {
        //TODO write sort
        return people;
    }

    public string[] getFullNameArray()
    {
        return this.people.Select( x => x.fullName).ToArray();
    }

    public string getFullNameStr()
    {
        return String.Join(System.Environment.NewLine, getFullNameArray());
    }

    public void displayAllNames()
    {
        foreach (string name in getFullNameArray())
        {
            Console.WriteLine(name);
        }
    }
}