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
            var randomQuestions = _repositorio.GetQuestions(5);
            var relations = _repositorio.getAnswers(randomQuestions);

            _repositorio.preguntas = null;
            _repositorio.preguntas = relations;

            return View(relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswers(List<string> answers)
        {
            var relations = _repositorio.preguntas;

            foreach (var rel in relations)
            {

                if (!rel.answerList.Contains(rel.answer))
                {
                    rel.answerList.Add(rel.answer);
                }
            }

            for (int i = 0; i < relations.Count; i++)
            {
                string selectedAnswer = answers[i];

                relations[i].selectedItem = relations[i].answerList.FirstOrDefault(a => a.ToString() == selectedAnswer);
            }

            foreach (var rel in relations)
            {
                if (rel.selectedItem == rel.answer)
                {
                    rel.grade = 1;
                }
                else
                {
                    rel.grade = 0;
                }
            }

            return View("ResultMC", relations);
        }

    }
}
