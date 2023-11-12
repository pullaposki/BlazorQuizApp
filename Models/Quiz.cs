namespace QuizApp.Models
{
	public class Quiz
    {
        public List<Question> Questions { get; set; }
    }

    public class Question
    {
        public string QuestionText { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

    }
}
