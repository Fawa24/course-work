using CourseWork.Entities;
using CourseWork.IServiceContracts.DTO;
using CourseWork.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CourseWork.IServiceContracts.Support
{
	public class QASectionHandler : BaseHandler
	{
		private readonly DishDbContext _db;

		public QASectionHandler()
		{
			_db = new DishDbContext();
			Next = new SupportManagerHandler();
		}

		public override string Handle(string question)
		{
			string? answer = FindSimilarQuestion(question);
			if (answer == null && Next == null) return "No answer was found";
			if (answer == null && Next != null) return Next.Handle(question);
			if (answer != null)
			{
                return answer;
            }
			else
			{
				return "Something went wrong";
			}
		}

		public string? FindSimilarQuestion(string question)
		{
			var targetWords = new HashSet<string>(question.Split(' '));

            int sentenceLength = targetWords.ToList().Count;

            Pair similarQuestion = new Pair();

            List<UserQuestion> questions = _db.UserQuestions.Include(e => e.Answer).ToList();

			foreach (UserQuestion s in questions)
			{
				string[] words = s.QuestionText.Split(' ');

				var questionWords = new HashSet<string>(words);

				questionWords.IntersectWith(targetWords);

				if (questionWords.Count > similarQuestion.WordsNumber && questionWords.Count > sentenceLength / 2)
				{
					similarQuestion.WordsNumber = questionWords.Count;
					similarQuestion.UserQuestion = s;
				}
			}

			string? result;

            if (similarQuestion.WordsNumber > 0 && similarQuestion.UserQuestion.Answer == null)
			{
				result = "Question has been alreay published by another user but hasn't been answered yet.";
			}
			else
			{
                result = similarQuestion.UserQuestion?.Answer?.AnswerText;
            }

			return result;
		}
	}
}
