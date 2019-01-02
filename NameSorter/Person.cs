using System;

public class Person
{
    public string lastName { get; set; }
    public string[] givenName { get; set; }
    public string fullName { get; set; }

    public Person(string lastName = null, string[] givenName = null)
    {
        this.lastName = lastName;
        this.givenName = givenName;
        this.fullName= String.Join(" ", this.givenName) + " " + this.lastName;
    }
}