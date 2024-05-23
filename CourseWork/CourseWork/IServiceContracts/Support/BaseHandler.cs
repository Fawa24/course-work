namespace CourseWork.IServiceContracts.Support
{
	public abstract class BaseHandler
	{
		public BaseHandler? Next { get; set; }

		public abstract string Handle(string question);
	}
}
