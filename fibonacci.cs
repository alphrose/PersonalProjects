using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//************************************************************
// Demonstrates the fibonacci sequence.
//
// created by @alphrose
// version_1.3_11.6.17
//************************************************************

namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
		    int firstNum = 0;
		    int secNum;
		    int newNum = 1;
		    Console.WriteLine("0"); // Write the first number in the sequence
		    
		    // loop that finishes off the rest of the sequence
		    for(;newNum <= 34;)
		    {
		        Console.WriteLine(newNum);
		        secNum = firstNum;
		        firstNum = newNum;
		        newNum = secNum + firstNum;
		    }
		    
		    Console.WriteLine("And so on and so forth. . .");
		}
	}
}
