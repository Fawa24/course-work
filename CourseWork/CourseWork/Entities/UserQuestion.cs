using System;
using System.Collections.Generic;

namespace CourseWork.Entities;

public partial class UserQuestion
{
    public Guid QuestionId { get; set; }

    public string QuestionText { get; set; } = null!;

    public Guid? AnswerId { get; set; }

    public virtual QuestionAnswer? Answer { get; set; }
}
