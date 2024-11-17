namespace QuizzMVC.Models;

public abstract class Question
{
    public string Text { get; set; }
    public abstract bool CheckAnswer(string answer);
}
