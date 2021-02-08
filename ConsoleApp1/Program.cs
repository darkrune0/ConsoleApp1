using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		public static void Main(string[] args)
		{   
			//shipping info
			string Adress = "palaiokastrou 18";
			string ZipCode = "81400";
			string Region = "Lesbou";
			string Country = "Greece";
			//test variables
			bool ValidZC;
			bool ValidRg = false;

			//normalize zip code
			if (ZipCode.Contains('-')) ZipCode = ZipCode.Replace("=", "");
			if (ZipCode.Contains(' ')) ZipCode = ZipCode.Replace(" ", "");

			//check if Zip Code is valid
			long j;
			if (!Int64.TryParse(ZipCode.Substring(0, ZipCode.Length - 1), out j))
				ValidZC = false;
			else if (ZipCode.Length != 5)
				ValidZC = false;
			else
				ValidZC = true;


			//create a hash table for the Zip code and region matches.
			Hashtable ht = new Hashtable();
			string[] post = new string[] { "10", "11", "12", "13" , "14", "15", "16", "17", "18", "19", "80"};
			ht.Add("Attikhs", post );

			post = new string[]{"20"};
			ht.Add("Korinthias", post);

			post = new string[] { "21" };
			ht.Add("Argolidas", post);

			post = new string[] { "22" };
			ht.Add("Arkadias", post);

			post = new string[] { "23" };
			ht.Add("Lakonias", post);
			
			post = new string[] { "24" };
			ht.Add("Messinias", post);
			
			post = new string[] { "25", "26"};
			ht.Add("Achaias", post);
			
			post = new string[] { "27" };
			ht.Add("Hleias", post);
			
			post = new string[] { "28" };
			ht.Add("Kefallinias", post);
			
			post = new string[] { "29" };
			ht.Add("Zakinthou", post);
			
			post = new string[] { "20" };
			ht.Add("Aitoloakarnanias", post);
			
			post = new string[] { "31" };
			ht.Add("Leukadas", post);
			
			post = new string[] { "32" };
			ht.Add("Boiwtias", post);
			
			post = new string[] { "33" };
			ht.Add("Fwkidas", post);
			
			post = new string[] { "34" };
			ht.Add("Euboias", post);
			
			post = new string[] { "35" };
			ht.Add("Fthiotidas", post);
			
			post = new string[] { "36" };
			ht.Add("Eurutanias", post);
			
			post = new string[] { "37", "38" };
			ht.Add("Magnisias", post);
			
			post = new string[] { "40", "41" };
			ht.Add("Larisas", post);
			
			post = new string[] { "42" };
			ht.Add("Trikalwn", post);
			
			post = new string[] { "43" };
			ht.Add("Karditsas", post);
			
			post = new string[] { "44", "45" };
			ht.Add("Iwanninwn", post);
			
			post = new string[] { "46" };
			ht.Add("Thesprwtias", post);
			
			post = new string[] { "47" };
			ht.Add("Artas", post);
			
			post = new string[] { "48" };
			ht.Add("Prebezas", post);
			
			post = new string[] { "49" };
			ht.Add("Kerkuras", post);
			
			post = new string[] { "50" };
			ht.Add("Kozanhs", post);
			
			post = new string[] { "51" };
			ht.Add("Grebenwn", post);
			
			post = new string[] { "52" };
			ht.Add("Kastorias", post);
			
			post = new string[] { "53" };
			ht.Add("Flwrinas", post);
			
			post = new string[] { "54", "55", "56", "57" };
			ht.Add("Thessalonikhs", post);
			
			post = new string[] { "58" };
			ht.Add("Pellas", post);
			
			post = new string[] { "59" };
			ht.Add("Hmathias", post);
			
			post = new string[] { "60" };
			ht.Add("Pierias", post);
			
			post = new string[] { "61" };
			ht.Add("Kilkis", post);
			
			post = new string[] { "62" };
			ht.Add("Serrwn", post);
			
			post = new string[] { "63" };
			ht.Add("Xalkidikhs", post);
			
			post = new string[] { "64", "65" };
			ht.Add("Kabalas", post);

			post = new string[] { "66" };
			ht.Add("Dramas", post);
			
			post = new string[] { "67" };
			ht.Add("Janthhs", post);
			
			post = new string[] { "68" };
			ht.Add("Ebrou", post);
			
			post = new string[] { "69" };
			ht.Add("Rodophs", post);
			
			post = new string[] { "70", "71"};
			ht.Add("Hrakleiou", post);

			post = new string[] { "72" };
			ht.Add("Lasithiou", post);
			
			post = new string[] { "73" };
			ht.Add("Xaniwn", post);
			
			post = new string[] { "74" };
			ht.Add("Rethumnhs", post);
			
			post = new string[] { "81" };
			ht.Add("Lesbou", post);
			
			post = new string[] { "82" };
			ht.Add("Xiou", post);
			
			post = new string[] { "83" };
			ht.Add("Samou", post);
			
			post = new string[] { "84" };
			ht.Add("Kukladwn", post);
			
			post = new string[] { "85" };
			ht.Add("Dwdekanhsou", post);

			//check if the Region 
			ICollection keys = ht.Keys;
			if (ValidZC)
			{
				foreach (string k in keys)
				{
					string[] postcode = (string[])ht[k];
					if (Region == k)
					{
						foreach (string s in postcode)
						{
							if (ZipCode.StartsWith(s))
							{
								ValidRg = true;
								break;
							}
						}
						break;
					}
					else
                        ValidRg = false;
				}
			}

			//Console.WriteLine("Zip Code:" + ZipCode + " is " + ValidZC + "\nRegion is " + ValidRg + " For Nomos " + Region);
			bool checkZip;
			if(ValidZC && ValidRg)
				checkZip = true; 
			else
				checkZip = false;
			Console.WriteLine("for Nomos " + Region + " and " + ZipCode + " the match is " + checkZip);
			//return checkZip;
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

/*Check Zip Code

			//shipping info
			string Adress = "palaiokastrou 18";
			string ZipCode = "81400";
			string Region = "Lesbou";
			string Country = "Greece";
			//test variables
			bool ValidZC;
			bool ValidRg = false;

			//normalize zip code
			if (ZipCode.Contains('-')) ZipCode = ZipCode.Replace("=", "");
			if (ZipCode.Contains(' ')) ZipCode = ZipCode.Replace(" ", "");

			//check if Zip Code is valid
			long j;
			if (!Int64.TryParse(ZipCode.Substring(0, ZipCode.Length - 1), out j))
				ValidZC = false;
			else if (ZipCode.Length != 5)
				ValidZC = false;
			else
				ValidZC = true;


			//create a hash table for the Zip code and region matches.
			Hashtable ht = new Hashtable();
			string[] post = new string[] { "10", "11", "12", "13" , "14", "15", "16", "17", "18", "19", "80"};
			ht.Add("Attikhs", post );

			post = new string[]{"20"};
			ht.Add("Korinthias", post);

			post = new string[] { "21" };
			ht.Add("Argolidas", post);

			post = new string[] { "22" };
			ht.Add("Arkadias", post);

			post = new string[] { "23" };
			ht.Add("Lakonias", post);
			
			post = new string[] { "24" };
			ht.Add("Messinias", post);
			
			post = new string[] { "25", "26"};
			ht.Add("Achaias", post);
			
			post = new string[] { "27" };
			ht.Add("Hleias", post);
			
			post = new string[] { "28" };
			ht.Add("Kefallinias", post);
			
			post = new string[] { "29" };
			ht.Add("Zakinthou", post);
			
			post = new string[] { "20" };
			ht.Add("Aitoloakarnanias", post);
			
			post = new string[] { "31" };
			ht.Add("Leukadas", post);
			
			post = new string[] { "32" };
			ht.Add("Boiwtias", post);
			
			post = new string[] { "33" };
			ht.Add("Fwkidas", post);
			
			post = new string[] { "34" };
			ht.Add("Euboias", post);
			
			post = new string[] { "35" };
			ht.Add("Fthiotidas", post);
			
			post = new string[] { "36" };
			ht.Add("Eurutanias", post);
			
			post = new string[] { "37", "38" };
			ht.Add("Magnisias", post);
			
			post = new string[] { "40", "41" };
			ht.Add("Larisas", post);
			
			post = new string[] { "42" };
			ht.Add("Trikalwn", post);
			
			post = new string[] { "43" };
			ht.Add("Karditsas", post);
			
			post = new string[] { "44", "45" };
			ht.Add("Iwanninwn", post);
			
			post = new string[] { "46" };
			ht.Add("Thesprwtias", post);
			
			post = new string[] { "47" };
			ht.Add("Artas", post);
			
			post = new string[] { "48" };
			ht.Add("Prebezas", post);
			
			post = new string[] { "49" };
			ht.Add("Kerkuras", post);
			
			post = new string[] { "50" };
			ht.Add("Kozanhs", post);
			
			post = new string[] { "51" };
			ht.Add("Grebenwn", post);
			
			post = new string[] { "52" };
			ht.Add("Kastorias", post);
			
			post = new string[] { "53" };
			ht.Add("Flwrinas", post);
			
			post = new string[] { "54", "55", "56", "57" };
			ht.Add("Thessalonikhs", post);
			
			post = new string[] { "58" };
			ht.Add("Pellas", post);
			
			post = new string[] { "59" };
			ht.Add("Hmathias", post);
			
			post = new string[] { "60" };
			ht.Add("Pierias", post);
			
			post = new string[] { "61" };
			ht.Add("Kilkis", post);
			
			post = new string[] { "62" };
			ht.Add("Serrwn", post);
			
			post = new string[] { "63" };
			ht.Add("Xalkidikhs", post);
			
			post = new string[] { "64", "65" };
			ht.Add("Kabalas", post);

			post = new string[] { "66" };
			ht.Add("Dramas", post);
			
			post = new string[] { "67" };
			ht.Add("Janthhs", post);
			
			post = new string[] { "68" };
			ht.Add("Ebrou", post);
			
			post = new string[] { "69" };
			ht.Add("Rodophs", post);
			
			post = new string[] { "70", "71"};
			ht.Add("Hrakleiou", post);

			post = new string[] { "72" };
			ht.Add("Lasithiou", post);
			
			post = new string[] { "73" };
			ht.Add("Xaniwn", post);
			
			post = new string[] { "74" };
			ht.Add("Rethumnhs", post);
			
			post = new string[] { "81" };
			ht.Add("Lesbou", post);
			
			post = new string[] { "82" };
			ht.Add("Xiou", post);
			
			post = new string[] { "83" };
			ht.Add("Samou", post);
			
			post = new string[] { "84" };
			ht.Add("Kukladwn", post);
			
			post = new string[] { "85" };
			ht.Add("Dwdekanhsou", post);

			//check if the Region 
			ICollection keys = ht.Keys;
			if (ValidZC)
			{
				foreach (string k in keys)
				{
					string[] postcode = (string[])ht[k];
					if (Region == k)
					{
						foreach (string s in postcode)
						{
							if (ZipCode.StartsWith(s))
							{
								ValidRg = true;
								break;
							}
						}
						break;
					}
					else
                        ValidRg = false;
				}
			}

			//Console.WriteLine("Zip Code:" + ZipCode + " is " + ValidZC + "\nRegion is " + ValidRg + " For Nomos " + Region);
			bool checkZip;
			if(ValidZC && ValidRg)
				checkZip = true; 
			else
				checkZip = false;
			Console.WriteLine("for Nomos " + Region + " and " + ZipCode + " the match is " + checkZip);
			//return checkZip;
*/