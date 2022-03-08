using System;
using System.Text.RegularExpressions;

namespace Test.Questions
{
	class QuestionOne
	{
		private string _defaultEntry;
		public string _defaultAnswer { get; private set; }
		private string _question;

		public QuestionOne()
		{
			_question = "Le but de cet exercice est de remplacer chaque 'j', 'ch' ou 's' par un 'z' à l'aide d'une regex.";
			_defaultEntry = "j'ai un cheveu sur la langue";
			_defaultAnswer = "z'ai un zeveu zur la langue";
		}

		public string SolveQuestion(string? newEntry)
		{
			if (newEntry == null) newEntry = _defaultEntry;
			if (newEntry.Length == 0) newEntry = _defaultEntry;

			string pattern = @"[js]|ch";
			string replace = "z";

			return Regex.Replace(newEntry, pattern, replace);
		}
	}
}
