using Xunit;
using Test.Questions;
using System;
using System.Collections.Generic;

namespace Test;

public class UnitTest
{
	[Fact]
	public void QuestionOneClassInstanciationTest()
	{
		QuestionOne question = new QuestionOne();

		Assert.NotNull(question);
	}

	[Fact]
	public void QuestionOneDefaultResult()
	{
		QuestionOne question = new QuestionOne();

		Assert.Equal(question._defaultAnswer, question.SolveQuestion(null));
	}

	[Theory]
	[InlineData("jaja", "zaza")]
	public void QuestionOneChosenResult(string toSolve, string newSolution)
	{
		QuestionOne question = new QuestionOne();

		Assert.Equal(newSolution, question.SolveQuestion(toSolve));
	}

	[Fact]
	public void QuestionTwoClassInstanciationTest()
	{
		QuestionTwo question = new QuestionTwo();

		Assert.NotNull(question);
	}

	[Fact]
	public void QuestionTwoResult()
	{
		QuestionTwo question = new QuestionTwo();

		List<string> response = question.SolveQuestion();

		for (int i = 0; i < response.Count; i++)
		{
			Assert.Equal(question._answer[i], response[i]);
			Console.WriteLine(response[i]);
		}

	}

	[Fact]
	public void QuestionThreeClassInstanciationTest()
	{
		QuestionThree question = new QuestionThree();

		Assert.NotNull(question);
	}

	[Theory]
	[InlineData(8)]
	public void QuestionThreeResult(int nbOfOutputtedElement)
	{
		QuestionThree question = new QuestionThree();

		List<int> response = question.SolveQuestion(nbOfOutputtedElement);

		for (int i = 0; i < response.Count; i++)
		{
			Assert.Equal((i + 1) * 3, response[i]);
			Console.WriteLine(response[i]);
		}

	}
}
