using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpCalculator;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculator calc = new Calculator();
			
			Console.Write(calc.Sub(int.MinValue, int.MaxValue));
		}
	}
}
