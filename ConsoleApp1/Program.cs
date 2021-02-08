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
			string CardID = "4929011835589952";
			bool ValidCard;
			string CardType;
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