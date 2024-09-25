namespace BinaryCipher
{
	public class Program
	{
		static void Main(string[] args)
		{

			bool state = true;


			while (state)
			{
				Beautifier.CoolHeader("", "Welcome to the Binary Cipher! \n");
				string userChoice = Beautifier.CoolMenu("", "Encrypt", "Decrypt", "Exit");
				Console.Clear();



				if (userChoice == "Encrypt")
				{
					Beautifier.CoolHeader("Encrypt", "Please enter the text you would like to encrypt: ");
					try
					{
						string userInputText = Convert.ToString(Console.ReadLine());
						List<string> binaryList = Binary.Encrypt(userInputText);
						Beautifier.CoolHeader("Encrypted Text", "Here is your encrypted text: ");
						foreach (string s in binaryList)
						{
							Console.WriteLine(s);
						}
						Console.ReadKey();
						Console.Clear();

					}
					catch (Exception ex)
					{
						Console.WriteLine("An error occurred: " + ex.Message);
					}

				}
				if (userChoice == "Decrypt")
				{
					Beautifier.CoolHeader("Decrypt", "Please enter the text you would like to decrypt: ");
					string userInputText2 = Console.ReadLine();
					//string decryptedText = Binary.Decrypt(userInputText2);
					//Beautifier.CoolHeader("Decrypted Text", "Here is your decrypted text: ");
					//Console.WriteLine(decryptedText);
					Console.ReadKey();
					Console.Clear();
				}

				if (userChoice == "Exit")
				{
					state = false;
					Console.ReadKey();
					Console.Clear();
				}
			}

		}
	}

	//public static string Decrypt(string userInputText)
	//{
	//	return text;
	//}


}

