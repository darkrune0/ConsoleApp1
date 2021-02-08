using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		public static void Main(string[] args)
        {   //check Zip Code
			//shipping info
			string Adress;
			string ZipCode;
			string Region;
			string Country;
			//test variables
			bool ValidZC;
			bool ValidRg;


		}
	}
}



/* Valid ISBN
 *  
			//bool value = Isbn.ValidISBN("960-751-094-1");
			//bool value;
			string isbn = "123-456-789-0";
			bool result = false;
			//remove any dashes, that might exist
			if (isbn.Contains('-')) isbn = isbn.Replace("-", "");
			if (!string.IsNullOrEmpty(isbn))
			{
				long j;
				if (isbn.Length == 10)
				{
					// Check if it contains any non numeric chars, if yes, return false
					if (!Int64.TryParse(isbn.Substring(0, isbn.Length - 1), out j))
						result = false;
					// Checking if the last char is not 'X' and
					// and if it's a numeric value
					char lastChar = isbn[isbn.Length - 1];
					if (lastChar == 'X' && !Int64.TryParse(lastChar.ToString(), out j))
						result = false;
					int sum = 0;
					// Using the alternative way of calculation
					for (int i = 0; i < 9; i++)
						sum += Int32.Parse(isbn[i].ToString()) * (i + 1);
					// Getting the remainder or the checkdigit
					int remainder = sum % 11;
					// Check if the checkdigit is same as the last number of ISBN 10 code
					result = (remainder == int.Parse(isbn[9].ToString()));
				}
				else if (isbn.Length == 13)
				{
					int sum = 0;
					//multiply by 1 or 3, alternating, from left to right and summing them
					for (int i = 0; i < 12; i++)
					{
					    sum += Int32.Parse(isbn[i].ToString()) * (i % 2 == 1 ? 3 : 1);
					}
					//Check if the check digit(last digit) is the same with our resulting check digit
					int remainder = sum % 10;
					int checkDigit = 10 - remainder;
					if (checkDigit == 10) checkDigit = 0;
					result = (checkDigit == int.Parse(isbn[12].ToString()));
				}
				else
					result = false;

				Console.WriteLine(result);//value is boolean(true/false)
			} 
 */

/* Check Card Num
 * 
			//variables for testing
			string CardID = "6388420075915958";
			bool ValidCard = false;
			string CardType = "";
			//card id normalization
			if (CardID.Contains('-')) CardID = CardID.Replace("=", "");
			if (CardID.Contains(' ')) CardID = CardID.Replace(" ", "");
			if (!string.IsNullOrEmpty(CardID))
            {
				int i, checkSum = 0;
				//compute checksum for even digits
				for (i = CardID.Length - 1; i >= 0; i -= 2)
                	checkSum += (Int32.Parse(CardID[i].ToString()));
                //compute checksum of odd digits multiplied by 2
				for (i = CardID.Length - 2; i >= 0; i -= 2)
                {
					int val = ((Int32.Parse(CardID[i].ToString())) * 2);
					while (val > 0)
                    {
						checkSum += val % 10;
						val /= 10;
                    }
                }
				Console.WriteLine((checkSum % 10) == 0);
				if((checkSum % 10) == 0) ValidCard = true;
				Console.WriteLine("the answer is " + ValidCard);
				//TODO get info on which is the type of the credit card

				//this set of string[] are the data set for the card Type check
                string[] cAmExp = new string[] { "34", "37" };
                string[] cMaest = new string[] { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
                string[] cMastC = new string[] { "51", "52", "53", "54", "55" };
                string[] cVisa = new string[] { "4" };
                
                //check card type
                if (ValidCard)
                {
                    foreach (string s in cAmExp)
                        if (CardID.StartsWith(s)) CardType = "American Express";
                    foreach (string s in cMaest)
                        if (CardID.StartsWith(s)) CardType = "Maestro";
                    foreach (string s in cMastC)
                        if (CardID.StartsWith(s)) CardType = "Master Card";
                    foreach (string s in cVisa)
                        if (CardID.StartsWith(s)) CardType = "Visa";
					Console.WriteLine(CardType);
				}
            }
 */