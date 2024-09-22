namespace BinaryCipher
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<string> binaryList = Encrypt("ALISSA");

			foreach (string s in binaryList)
			{
				Console.WriteLine(s);
			}
		}

		public static List<string> Encrypt(string userInputText)
		{
			string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
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

				for (int j = 0; j < alphabet.Length; j++)
				{

					if (sortedText[i].ToString() == alphabet[j])
					{
						int temp = j+1;
						int binValue = 16;

						for (int k = 0; k < 5; k++)
						{
							if(temp >= binValue)
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

		//public static string Decrypt(string userInputText)
		//{
		//	return text;
		//}

		public static List<string> StringSorter(string text)
		{
			List<string> sortedText = new List<string>();

			foreach (char c in text)
			{
				sortedText.Add(c.ToString());
			}

			return sortedText;
		}
	}
}
