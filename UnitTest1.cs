using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;
namespace MathAndStringTests
{
    public class StringOperations
    {
        public string Trim(string str) => str.Trim();
    }
    [Fact]
    public void Test05_TrimWhitespace()
    {
        string input = "   Hello World   ";
        string expected = "Hello World";
        string result = _stringOps.Trim(input);
        Assert.Equal(expected, result);
    }
}