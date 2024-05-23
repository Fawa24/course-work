using CourseWork.Entities;

namespace CourseWork.IServiceContracts.Support
{
	public class SupportManagerHandler : BaseHandler
	{
		private readonly DishDbContext _db;

		public SupportManagerHandler()
		{
			_db = new DishDbContext();
			Next = null;
		}

		public override string Handle(string question)
		{
			_db.UserQuestions.Add(new UserQuestion() { QuestionId = Guid.NewGuid(), QuestionText = question});
			_db.SaveChanges();
			return "Question was puplished. Periodicaly check this window for the responce";
		}
	}
}
