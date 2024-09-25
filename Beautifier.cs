using Spectre.Console;

namespace BinaryCipher
{
	public static class Beautifier
	{
		public static void CoolHeader(string panelHeader, string panelText)
		{
			Console.WriteLine("\n \n");
			var panel = new Panel(panelText);
			panel.Header(panelHeader);
			panel.BorderColor(Color.Red3);
			AnsiConsole.Write(panel);
		}

		public static void CoolLine()
		{
			var rule = new Rule();
			AnsiConsole.Write(rule);
		}

		public static string CoolMenu(string title, string choice1, string choice2, string choice3)//Method overload for 2 choices
		{
			CoolLine();
			string playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
				.Title($"{title}")
				.PageSize(3)
				.AddChoices(choice1, choice2, choice3));
			return playerChoice;
		}


	}
}
