namespace QuizzMVC.Models;

public class QuizModel
{
    public List<Question> Questions { get; set; }
    public int CurrentQuestionIndex { get; set; } = 0;
    public int CorrectAnswersCount { get; set; } = 0;

    public bool IsFirstQuestion() => CurrentQuestionIndex == 0;
    public bool IsLastQuestion() => CurrentQuestionIndex == Questions.Count - 1;

    public void NextQuestion() => CurrentQuestionIndex++;
    public void PreviousQuestion() => CurrentQuestionIndex--;
    public string GetCurrentQuestionText() => Questions[CurrentQuestionIndex].Text;
}
