using QuizApp.Models;

namespace QuizApp.Services
{
	interface IQuizService
	{
		public Quiz GetQuiz();
		public int GetScore();
	}

	public class QuizService: IQuizService
	{
		Quiz _quiz;
		int _score;

		public QuizService()
		{
			_quiz = new Quiz
			{
				Questions = new List<Question>
				{
					new Question
					{
						QuestionText = "Sample Question",
						Answers = new List<string> { "A1", "A2", "A3" },
						CorrectAnswerIndex = 0
					},
				}

			};

		}


		public bool CheckAnswer(Question question ,int answerIndex)
		{
			if(question.CorrectAnswerIndex == answerIndex)
			{
				_score++;
				return true;
			}

			return false;	
		}


		public Quiz GetQuiz() => _quiz;
		public int GetScore() => _score;
	}
}
