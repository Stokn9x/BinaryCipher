namespace BinaryCipher
{
	public class Program
	{
		static void Main(string[] args)
		{

			bool state = true;
			Beautifier.CoolHeader("", "Welcome to the Binary Cipher! \n");

			while (state)
			{

				string userChoice = Beautifier.CoolMenu("Main Menu", "Encrypt", "Decrypt", "Exit");
				Console.Clear();
				switch (userChoice)
				{
					case "Encrypt":
						Beautifier.CoolHeader("Encrypt", "Please enter the text you would like to encrypt: ");
						string userInputText = Console.ReadLine();
						List<string> binaryList = Binary.Encrypt(userInputText);
						Beautifier.CoolHeader("Encrypted Text", "Here is your encrypted text: ");
						foreach (string s in binaryList)
						{
							Console.WriteLine(s);
						}
						Console.ReadKey();
						Console.Clear();
						break;

					case "Decrypt":
						Beautifier.CoolHeader("Decrypt", "Please enter the text you would like to decrypt: ");
						string userInputText2 = Console.ReadLine();
						//string decryptedText = Binary.Decrypt(userInputText2);
						//Beautifier.CoolHeader("Decrypted Text", "Here is your decrypted text: ");
						//Console.WriteLine(decryptedText);
						Console.ReadKey();
						Console.Clear();
						break;

					case "Exit":
						state = false;
						Console.ReadKey();
						Console.Clear();
						break;
				}

			}
		}

		//public static string Decrypt(string userInputText)
		//{
		//	return text;
		//}


	}
}
