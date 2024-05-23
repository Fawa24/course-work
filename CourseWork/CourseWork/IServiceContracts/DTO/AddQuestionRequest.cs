using CourseWork.Entities;

namespace CourseWork.IServiceContracts.DTO
{
	public class AddQuestionRequest
	{
		public string QuestionText { get; set; } = null!;

		public UserQuestion ToQuestion()
		{
			return new UserQuestion { QuestionId = Guid.NewGuid(), QuestionText = QuestionText };
		}
	}
}
