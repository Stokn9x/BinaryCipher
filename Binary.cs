using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCipher
{
	public static class Binary
	{
		private static string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

		public static List<string> StringSorter(string text)
		{
			List<string> sortedText = new List<string>();

			foreach (char c in text)
			{
				sortedText.Add(c.ToString());
			}

			return sortedText;
		}

		public static List<string> BinarySorter(string text)
		{
			List<string> sortedBinary = new List<string>();

			for()
		}

		public static List<string> Encrypt(string userInputText)
		{
			List<string> sortedText = StringSorter(userInputText);
			List<string> binaryList = new List<string>();
			bool isUpper = false;
			for (int i = 0; i < sortedText.Count; i++)
			{
				string tempNumber = "";
				if (sortedText[i].ToString() == sortedText[i].ToString().ToUpper())
				{
					tempNumber += "010";
					isUpper = true;
				}
				else
				{
					tempNumber += "011";
					isUpper = false;
				}
				//TODO This dont take lower case letters into account
				for (int j = 0; j < alphabet.Length; j++)
				{

					if (sortedText[i].ToString() == alphabet[j])
					{
						int temp = j + 1;
						int binValue = 16;

						for (int k = 0; k < 5; k++)
						{
							if (temp >= binValue)
							{
								tempNumber += "1";
							}
							else
							{
								tempNumber += "0";
							}

							binValue /= 2;
						}

						binaryList.Add(tempNumber);
					}
				}
			}

			return binaryList;
		}

		public static List<string> Decrypt(string userInputText)
		{
			List<string> sortedBinary = StringSorter(userInputText);
			List<string> textList = new List<string>();



		}

	}
}
