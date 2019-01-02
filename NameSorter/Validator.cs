using System;

public class Validator
{
    public bool argsNumberOne(string[] args) => args.Length == 1;

    public void validate(string[] args)
    {
        if (!argsNumberOne(args)) 
        {
            Console.WriteLine("Please use the format: dotnet run path_to_unsorted_file");
            Environment.Exit(1);
        }
    }
}