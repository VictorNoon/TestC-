using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Test.Questions
{
	class QuestionTwo
	{
		private string[] _names;
		public string[] _answer { get; private set; }
		private string _question;

		public QuestionTwo()
		{
			_question = "Le but de cet exercice est de ne selectionner que les noms commençant par B, les mettre en majuscule et ensuite les trier par ordre alphabetique.";
			_names = new string[] { "Billy", "Bob", "Benjamin", "Stephane" };
			_answer = new string[] { "BENJAMIN", "BILLY", "BOB", "Stephane" };
		}

		public List<string> SolveQuestion()
		{
			List<string> responseList = new List<string>();

			responseList.AddRange(_names);
			responseList = SetBNamesFromListToUpperList(responseList);
			responseList = SortNameFromList(responseList);
			return responseList;
		}

		private List<string> SortNameFromList(List<string> responseList)
		{
			responseList.Sort();

			return responseList;
		}

		private List<string> SetBNamesFromListToUpperList(List<string> nameList)
		{
			for (int i = 0; i < nameList.Count; i++)
			{
				if (nameList[i][0].ToString().ToLower() == "b")
					nameList[i] = nameList[i].ToUpper();
			}

			return nameList;
		}
	}
}
