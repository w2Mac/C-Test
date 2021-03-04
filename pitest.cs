using System;
 
namespace UserInput
{
	public class SeptaClass
	{
		public static void Main(string[] args)
		{
			string userInput1;
            string userInput2;
			int a;
			int b;

			Console.Write("Please give a number as 1st variable: ");
			userInput1 = Console.ReadLine();
			/* Converts to integer type */
			a = Convert.ToInt32(userInput1);
			
            Console.Write("Please give a number as 2nd variable: ");
			userInput2 = Console.ReadLine();
			/* Converts to double type */
			b = Convert.ToInt32(userInput2);
			
            Console.WriteLine("The value of the 1st variable: {0}",b);
            Console.WriteLine("The value of the 2nd variable: {0}",a);
		}
	}
}