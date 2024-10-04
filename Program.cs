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
					Beautifier.CoolLine();
					try
					{
						string userInputTextEncrypt = Convert.ToString(Console.ReadLine());
						List<string> encryptBinaryList = Binary.Encrypt(userInputTextEncrypt);
						Console.Clear();
						Beautifier.CoolHeader("Encrypted Text", "Here is your encrypted text: ");
						Beautifier.CoolLine();
						foreach (string s in encryptBinaryList)
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
					try
					{
						string userInputTextDecrypt = Convert.ToString(Console.ReadLine());
						List<string> decryptBinaryList = Binary.Decrypt(userInputTextDecrypt);
						Console.Clear();
						Beautifier.CoolHeader("Encrypted Text", "Here is your encrypted text: ");
						Beautifier.CoolLine();
						foreach (string s in decryptBinaryList)
						{
							Console.Write(s);
						}
						Console.ReadKey();
						Console.Clear();

					}
					catch (Exception ex)
					{
						Console.WriteLine("An error occurred: " + ex.Message);
					}
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

