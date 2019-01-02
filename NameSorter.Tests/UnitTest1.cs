using System;
using Xunit;
using NameSorter;

namespace NameSorter.Tests
{
    public class UnitTest1
    {
    	private readonly  Validator validator;

    	public UnitTest1()
    	{
    		this.validator = new Validator();
    	}
    	
        [Fact]
        public void FailArgumentsGreaterThanOne()
        {
            string[] args = {"inputa","input"};
        	Assert.False(validator.argsNumberOne(args));
        }
    }
}
