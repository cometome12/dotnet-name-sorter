using System.Collections.Generic;
using System;

public class PersonList
{
    public List<Person> people { get; set; }

    public void add(Person person)
    {
        try {
            people.Add(person);
        } catch (Exception e) {
            Console.WriteLine("Something went wrong when mapping the person. Message: "+ e.Message);
        }
    }

    public List<Person> sortByLastNameAndGivenNames()
    {
        //TODO write sort
        return people;
    }
}