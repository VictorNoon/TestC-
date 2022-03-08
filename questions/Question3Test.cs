using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Test.Questions
{
	class QuestionThree
	{
		private string _question;

		public QuestionThree()
		{
			_question = "Le but de cet exercice est d'afficher tous les multiples de 3 jusqu'à l'infini.";
		}

		public List<int> SolveQuestion(int nbDigits)
		{
			List<int> responseList = new List<int>();

			for (int i = 1; i <= nbDigits; i++)
				responseList.Add(i * 3);

			return responseList;
		}
	}
}
