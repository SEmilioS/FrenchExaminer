using FEWebApp.Data;
using FEWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FEWebApp.Controllers
{
    public class ExamenController : Controller
    {
        private readonly DB _repositorio;

        public ExamenController(DB repositorio)
        {
            _repositorio = repositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MultipleChoice()
        {
            List<MultipleChoiceViewModel> multipleChoiceQuestions = new List<MultipleChoiceViewModel>();
            var randomQuestions = _repositorio.GetQuestions(5);

            foreach (var questionText in randomQuestions)
            {
                var answerChoices = _repositorio.getAnswers(questionText);

                var viewModel = new MultipleChoiceViewModel
                {
                    QuestionText = questionText,
                    Choices = answerChoices
                };

                multipleChoiceQuestions.Add(viewModel);
            }

            return View(multipleChoiceQuestions);
        }
    }
}
