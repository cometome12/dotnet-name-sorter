using System;

public class Person
{
    public string lastName { get; set; }
    public string[] givenName { get; set; }
    public string fullName { get; set; }

    public Person(string lastName, string[] givenName)
    {
        this.lastName = lastName;
        this.givenName = givenName;
        //To String?
        this.fullName= String.Join(" ", this.givenName) + " " + this.lastName;
    }
}