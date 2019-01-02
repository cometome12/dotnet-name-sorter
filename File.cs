using System;
public class File
{
    private string[] entries;
    public string rawContent { get; set; }
    public File(string path)
    {
        try {
            this.entries = System.IO.File.ReadAllLines(path);
        } catch(Exception e) {
            Console.WriteLine("Something went wrong when reading the file. Message: "+ e.Message);
        }
    }

    public void emptyEntries()
    {
        Array.Clear(this.entries, 0, this.entries.Length);
    }

    public void mapNameToPersonList(PersonList list)
    {
        foreach (string entry in this.entries)
        {
            var entryArray = entry.Split(' ');
            //TODO here
            Person person = new Person(entryArray[1], entryArray);
            list.add(person);
        }
    }

    public void mapPersonListToFile(PersonList list) => rawContent = String.Join(System.Environment.NewLine, list.people);

    public void outputFileByRawContent(string path) => System.IO.File.WriteAllText(path, this.rawContent);
}