using System;
using System.Collections.Generic;

namespace CourseWork.Entities;

public partial class QuestionAnswer
{
    public Guid AnswerId { get; set; }

    public string AnswerText { get; set; } = null!;

    public virtual ICollection<UserQuestion> UserQuestions { get; set; } = new List<UserQuestion>();
}
