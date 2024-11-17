namespace QuizzMVC.Models;

public class TrueFalseQuestion : Question
{
    public bool CorrectAnswer { get; set; }

    public override bool CheckAnswer(string answer)
    {
        return (answer == "Verdadeiro" && CorrectAnswer) || (answer == "Falso" && !CorrectAnswer);
    }
}
