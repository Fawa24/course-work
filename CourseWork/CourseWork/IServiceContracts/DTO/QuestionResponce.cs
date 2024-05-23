using CourseWork.Entities;

namespace CourseWork.IServiceContracts.DTO
{
	public class QuestionResponce
	{
		public Guid QuestionId { get; set; }

		public string QuestionText { get; set; } = null!;

		public Guid? AnswerId { get; set; }

		public virtual QuestionAnswer? Answer { get; set; }
	}

	public static class UserQuestionExtension
	{
		public static QuestionResponce ToQuestionResponce(this UserQuestion userQuestion)
		{
			return new QuestionResponce() { 
				QuestionId = userQuestion.QuestionId,
				QuestionText = userQuestion.QuestionText,
				Answer = userQuestion.Answer,
				AnswerId = userQuestion.AnswerId
			};
		}
	}
}