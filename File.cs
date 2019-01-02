using System;
using System.Linq;
public class File
{
    private string[] entries;
    private string content;

    public File(string[] entries = null, string content = null)
    {
       this.entries = entries;
       this.content = content;
    }

    public void read(string path)
    {
        try {
            this.entries = System.IO.File.ReadAllLines(path);
        } catch(Exception e) {
            Console.WriteLine("Something went wrong when reading the file. Message: "+ e.Message);
            Environment.Exit(1);
        }
        this.content = String.Join(System.Environment.NewLine, this.entries);
    }

    public void mapNameToPersonList(PersonList list)
    {
        foreach (string entry in this.entries)
        {
            var entryArray = entry.Split(' ');
            Person person = new Person(entryArray.Last(), entryArray.Take(entryArray.Length - 1).ToArray());
            list.add(person);
        }
    }

    public void writeContent(string path) 
    {
        try {
            System.IO.File.WriteAllText(path, this.content);
        } catch(Exception e) {
            Console.WriteLine("Something went wrong when writing the file. Message: "+ e.Message);
            Environment.Exit(1);
        }
    }
}