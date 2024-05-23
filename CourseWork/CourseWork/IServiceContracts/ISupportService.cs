namespace CourseWork.IServiceContracts
{
	public interface ISupportService
	{
		/// <summary>
		/// Handles the question
		/// </summary>
		/// <param name="question">Question to handle</param>
		/// <returns>View name and data to display</returns>
		string Handle(string question);
	}
}