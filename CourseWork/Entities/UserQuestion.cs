namespace Entities.Entities;

public partial class UserQuestion
{
    public Guid QuestionId { get; set; }

    public string QuestionText { get; set; } = null!;
}
