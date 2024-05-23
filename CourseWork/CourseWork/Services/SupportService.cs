using CourseWork.IServiceContracts;
using CourseWork.IServiceContracts.Support;

namespace CourseWork.Services
{
	public class SupportService : ISupportService
	{
		private BaseHandler currentHundler;

		public SupportService()
		{
			currentHundler = new QASectionHandler();
		}

		public string Handle(string question)
		{
			return currentHundler.Handle(question);
		}
	}
}
