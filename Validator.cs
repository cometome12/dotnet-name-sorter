using System;

public class Validator
{
    public void validate(string[] args)
    {
        if (args.Length != 1) 
        {
            Console.WriteLine("Please use the format: dotnet run path_to_unsorted_file");
            Environment.Exit(1);
        }
    }
}