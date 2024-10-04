using System.ComponentModel.Design;

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

		public static List<string> Encrypt(string userInputText)
		{
			List<string> sortedText = StringSorter(userInputText);
			List<string> binaryList = new List<string>();
			bool isUpper = false;
			for (int i = 0; i < sortedText.Count; i++)
			{
				string tempNumber = "";
				if (sortedText[i].ToString() == sortedText[i].ToString().ToUpper() && sortedText[i].ToString() != " ")
				{
					tempNumber += "010";
					isUpper = true;
				}
				else if (sortedText[i].ToString() == " ")
				{
					tempNumber += "001";
				}
				else
				{
					tempNumber += "011";
					isUpper = false;
				}
				//TODO This dont take lower case letters into account
				for (int j = 0; j < alphabet.Length; j++)
				{
					if (tempNumber == "001")
					{
						tempNumber += "00000";
						binaryList.Add(tempNumber);
					}
					else if (sortedText[i].ToString() == alphabet[j])
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
			List<string> strings = new List<string>();

			int listLength = sortedBinary.Count / 7;



			for (int i = 0; i < listLength; i++)
			{
				string temp = "";

				for (int x = 0; x < 8; x++)
				{
					temp += sortedBinary[0];
					sortedBinary.RemoveAt(0);
				}

				textList.Add(temp);

			}

			for (int y = 0; y < textList.Count(); y++)
			{
				String tempString = textList[y];

				string letterList = "";

				bool isUpperCase = false;

				int bin = 16;

				int binNumber = 0;
				if (tempString == "00100000")
				{
					strings.Add(" ");
				}
				else if (tempString.Substring(0, 3) == "010")
				{
					isUpperCase = true;
					letterList = tempString.Substring(3);
					for (int x = 0; x < 5; x++)
					{
						if (letterList[x] == '1')
						{
							binNumber += bin;
							bin /= 2;
						}
						else 
						{
							bin /= 2;
						}
					}

					strings.Add(alphabet[binNumber - 1].ToUpper());


				}
				else
				{
					letterList = tempString.Substring(3);
					for (int x = 0; x < 5; x++)
					{
						if (letterList[x] == '1')
						{
							binNumber += bin;
							bin /= 2;
						}
						else
						{
							bin /= 2;
						}
					}

					strings.Add(alphabet[binNumber - 1].ToLower());
				}

			}

			return strings;



		}

	}
}
