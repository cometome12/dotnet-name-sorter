using System;

namespace dotnet_name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            // exception log??
            Validator validator = new Validator();
            validator.validate(args);
            File nameFile = new File(args[0]);
            PersonList personList = new PersonList();
            nameFile.mapNameToPersonList(personList);
            personList.sortByLastNameAndGivenNames();
            // write together??
            nameFile.emptyEntries();
            nameFile.mapPersonListToFile(personList);
            nameFile.outputFileByRawContent(AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
