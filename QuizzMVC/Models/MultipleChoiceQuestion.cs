namespace QuizzMVC.Models;

public class MultipleChoiceQuestion : Question
{
    public string[] Options { get; set; }
    public int CorrectAnswerIndex { get; set; }

    public override bool CheckAnswer(string answer)
    {
        return answer == Options[CorrectAnswerIndex];
    }
}
