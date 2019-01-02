using System;
using Xunit;
using NameSorter;

namespace NameSorter.Tests
{
    public class UnitTest1
    {
    	private readonly Validator validator;
        private readonly File file;
        private readonly PersonList people;

    	public UnitTest1()
    	{
    		this.validator = new Validator();
            this.file = new File();
            this.people = new PersonList();
    	}
    	
        [Fact]
        public void FailArgumentsGreaterThanOne()
        {
            string[] args = {"inputa","input"};
        	Assert.False(validator.argsNumberOne(args));
        }

        [Fact]
        public void TestAgainst1000Names()
        {
            file.read("../../../../test-names-list.txt");
            file.mapNameToPersonList(people);
            people.sortByLastNameAndGivenNames();
            string[] expected = {"Ah Ara", "Ba Aca Lava", "James Wob Parsons", 
            "James Wow Parsons", "Janet Parsons", "Janet Wob Parsons", 
            "Janet Wow Parsons", "John Parsons", "John Pooobo", "Wood Pooobo",
            "Colin Wise"};
            Assert.Equal(expected, people.getFullNameArray());
           
        }
    }
}
