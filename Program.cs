﻿using System;

namespace dotnet_name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Validator validator = new Validator();
            validator.validate(args);

            File unsortedNameFile = new File();
            unsortedNameFile.read(args[0]);

            PersonList personList = new PersonList();
            unsortedNameFile.mapNameToPersonList(personList);
            personList.sortByLastNameAndGivenNames();
            personList.displayAllNames();

            File sortedNameFile = new File(personList.getFullNameArray(), personList.getFullNameStr());
            sortedNameFile.writeContent(AppDomain.CurrentDomain.BaseDirectory + "/sorted-names-list.txt");
        }
    }
}
