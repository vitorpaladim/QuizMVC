using Microsoft.AspNetCore.Mvc;
using QuizzMVC.Models;

namespace QuizzMVC.Controllers;

public class HomeController : Controller
{
    private static QuizModel _quizModel;

    public HomeController()
    {
        if (_quizModel == null)
        {
            _quizModel = new QuizModel
            {
                Questions = new List<Question>
                {
                    new MultipleChoiceQuestion
                    {
                        Text = "Qual jogador é o maior artilheiro da história da Liga dos Campeões da UEFA?",
                        Options = new[] { "a. Cristiano Ronaldo", "b. Lionel Messi", "c. Bobby Charlton", "d. Robert Lewandowski" },
                        CorrectAnswerIndex = 1
                    },
                    new TrueFalseQuestion
                    {
                        Text = "paulo é o melhor professor.",
                        CorrectAnswer = true
                    },
                    new MultipleChoiceQuestion
                    {
                        Text = "Qual estádio é a casa do Corinthians desde 2014?",
                        Options = new[] { "a. Maracanã", "b. MorumBIS", "c. Neo Química Arena", "d. Vila Belmiro" },
                        CorrectAnswerIndex = 3
                    }
                }
            };
        }
    }

    public IActionResult Index()
    {
        return View(_quizModel);
    }

    [HttpPost]
    public IActionResult RegisterAnswer(string selectedAnswer)
    {
        var currentQuestion = _quizModel.Questions[_quizModel.CurrentQuestionIndex];

        if (currentQuestion.CheckAnswer(selectedAnswer))
        {
            _quizModel.CorrectAnswersCount++;
        }

        if (!_quizModel.IsLastQuestion())
        {
            _quizModel.NextQuestion();
            return RedirectToAction("Index");
        }

        return RedirectToAction("ShowResults");
    }

    public IActionResult PreviousQuestion()
    {
        if (!_quizModel.IsFirstQuestion())
        {
            _quizModel.PreviousQuestion();
        }
        return RedirectToAction("Index");
    }

    public IActionResult Skip()
    {
        if (!_quizModel.IsLastQuestion())
        {
            _quizModel.NextQuestion();
        }
        return RedirectToAction("Index");
    }

    public IActionResult ShowResults()
    {
        return View(_quizModel);
    }
}
