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
        {//check card num
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

				string[] cAmExp = new string[] {"34", "37"};
				string[] cDinCl = new string[] {"300", "301", "302", "303", "304", "305", "36", "54"};
				string[] cDisco = new string[] {"6011", "644", "645", "646", "647", "648", "649", "65"};
				string[] cInstP = new string[] {"637", "638", "639"};
				string[] cMaest = new string[] {"5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763"};
				string[] cMastC = new string[] {"51", "52", "53", "54", "55" };
				string[] cVisa = new string[] {"4"};
				string[] cJCB = new string[] {"35"};

				//check card type
				if (ValidCard)
                {
					foreach (string s in cAmExp)
						if(CardID.StartsWith(s)) CardType = "American Express";
					foreach (string s in cDinCl)
						if (CardID.StartsWith(s)) CardType = "Diners Club";
					foreach (string s in cInstP)
						if (CardID.StartsWith(s)) CardType = "InstaPayment";
					foreach (string s in cMaest)
						if (CardID.StartsWith(s)) CardType = "Maestro";
					foreach (string s in cMastC)
						if (CardID.StartsWith(s)) CardType = "Master Card";
					foreach (string s in cVisa)
						if (CardID.StartsWith(s)) CardType = "Visa";
					foreach (string s in cDisco)
						if (CardID.StartsWith(s)) CardType = "Discover";
					foreach (string s in cJCB)
						if (CardID.StartsWith(s)) CardType = "JCB";

					Console.WriteLine(CardType);
				}
            }
		}
	}
}



/* Valid ISBN
 
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
					// Comment Source: Wikipedia
					// The calculation of an ISBN-13 check digit begins with the first
					// 12 digits of the thirteen-digit ISBN (thus excluding the check digit itself).
					// Each digit, from left to right, is alternately multiplied by 1 or 3,
					// then those products are summed modulo 10 to give a value ranging from 0 to 9.
					// Subtracted from 10, that leaves a result from 1 to 10. A zero (0) replaces a
					// ten (10), so, in all cases, a single check digit results.

					for (int i = 0; i < 12; i++)
					{
						sum += Int32.Parse(isbn[i].ToString()) * (i % 2 == 1 ? 3 : 1);
					}
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
 
 */