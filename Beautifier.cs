using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			panel.BorderColor(Spectre.Console.Color.Red3);
			AnsiConsole.Write(panel);
		}

		public static void CoolLine()
		{
			var rule = new Rule();
			AnsiConsole.Write(rule);
		}

		public static string CoolMenu(string title, string choice1, string choice2)//Method overload for 2 choices
		{
			CoolLine();
			string playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
				.Title($"{title}")
				.PageSize(3)
				.AddChoices(choice1, choice2));
			return playerChoice;
		}

		public static string CoolMenu(string title, string choice1, string choice2, string choice3)//Method overload for 3 choices
		{
			CoolLine();
			string playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
				.Title($"{title}")
				.PageSize(4)
				.AddChoices(choice1, choice2, choice3));
			return playerChoice;
		}
		
		public static string CoolMenu(string title, string choice1, string choice2, string choice3, string choice4)//Method overload for 4 choices
		{
			CoolLine();
			string playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
				.Title($"{title}")
				.PageSize(5)
				.AddChoices(choice1, choice2, choice3, choice4));
			return playerChoice;
		}


	}
}
