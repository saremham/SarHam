using System;

namespace LargestandSmallest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter the first number: ");
			string firstNumberString = Console.ReadLine ();
			int firstNumber = int.Parse (firstNumberString); 

			Console.Write ("Enter the second number: ");
			string secondNumberString = Console.ReadLine ();
			int secondNumber = int.Parse (secondNumberString); 

			Console.Write ("Enter the third number: ");
			string thirdNumberString = Console.ReadLine ();
			int thirdNumber = int.Parse (thirdNumberString); 

			Console.Write ("Enter the fourth number: ");
			string fourthNumberString = Console.ReadLine ();
			int fourthNumber = int.Parse (fourthNumberString); 

			Console.Write ("Enter the fifth and final number: ");
			string fifthNumberString = Console.ReadLine ();
			int fifthNumber = int.Parse (fifthNumberString); 

			int biggestNumber = 0;
			if (firstNumber > secondNumber) {
				biggestNumber = firstNumber;
			} if (secondNumber > firstNumber) {
				biggestNumber = secondNumber;
			} if (secondNumber < thirdNumber) {
				biggestNumber = thirdNumber;
			} if (fourthNumber > thirdNumber) {
				biggestNumber = fourthNumber;
			} if (fourthNumber < fifthNumber) {
				biggestNumber = fifthNumber;
			} if (biggestNumber % 2 == 0) {
				Console.WriteLine ("The biggest number is " + biggestNumber + ", an even number.");
			} else {
				Console.WriteLine ("The biggest number is " + biggestNumber + ", an odd number.");
			}

			int smallestNumber = 0;
			if (firstNumber < secondNumber) {
				smallestNumber = firstNumber;
			} if (secondNumber < firstNumber) {
				smallestNumber = secondNumber;
			} if (secondNumber > thirdNumber) {
				smallestNumber = thirdNumber;
			} if (fourthNumber < thirdNumber) {
				smallestNumber = fourthNumber;
			} if (fourthNumber > fifthNumber) {
				smallestNumber = fifthNumber;
			} if (smallestNumber % 2 == 0) {
				Console.WriteLine ("The smallest number is " + smallestNumber + ", an even number.");
			} else {
				Console.WriteLine ("The smallest number is " + smallestNumber + ", an odd number.");
			}

		}
	}
}