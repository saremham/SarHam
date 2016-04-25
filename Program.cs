using System;

namespace SuperSimpleCalculator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Console.Write ("What is your name?");
			string name = Console.ReadLine (); 
			Console.WriteLine ("Hello" + name); 

			Console.Write ("Enter first number: ");
			string firstNumberString = Console.ReadLine ();
			int firstNumber = int.Parse (firstNumberString); 

			Console.Write ("Enter second number: ");
			string secondNumberString = Console.ReadLine (); 
			int secondNumber = int.Parse (secondNumberString);

			Console.Write ("Enter operator: ");
			string operatorString = Console.ReadLine ();
			Console.Write (firstNumberString + operatorString + secondNumberString + "=");
			if (operatorString == "*") { 
				Console.Write (firstNumber * secondNumber);
			} else if (operatorString == "+") {
				Console.Write (firstNumber + secondNumber);
			} else if (operatorString == "/") {
				Console.Write (firstNumber / secondNumber);
			} else if (operatorString == "-") {
				Console.Write (firstNumber - secondNumber);
			}

				
		}
	}
}
