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

        public IActionResult MCetre() 
        {
            return View();
        }

        public IActionResult EtrePresent()
        {
            if (!_repositorio.EtrePerfectCompleted)
            {
                var randomQuestions = _repositorio.getQuestionsEtre(10);
                var relations = _repositorio.getAnswersEtrePresent(randomQuestions);

                _repositorio.preguntas = null;
                _repositorio.preguntas = relations;

                foreach (var rel in relations)
                {
                    if (!rel.answerList.Contains(rel.answer))
                    {
                        rel.answerList.Add(rel.answer);
                    }
                }

                return View("MCcg", relations);
            }
            return RedirectToAction("Completed");
        }

        public IActionResult MCcg()
        {
            if (!_repositorio.CGcompleted)
            {
                var randomQuestions = _repositorio.GetQuestionsCG(10);
                var relations = _repositorio.getAnswers(randomQuestions);

                _repositorio.preguntas = null;
                _repositorio.preguntas = relations;

                foreach (var rel in relations)
                {
                    if (!rel.answerList.Contains(rel.answer))
                    {
                        rel.answerList.Add(rel.answer);
                    }
                }

                return View(relations);
            }
            return RedirectToAction("Completed");
        }

        [HttpPost]
        public IActionResult ProcessAnswersCG(List<string> answers)
        {
            _repositorio.CGcompleted = true;
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
                if (i < answers.Count)
                {
                    string selectedAnswer = answers[i];

                    relations[i].selectedItem = relations[i].answerList.FirstOrDefault(a => a.ToString() == selectedAnswer);

                    if (relations[i].selectedItem == relations[i].answer)
                    {
                        relations[i].grade = 1;
                    }
                    else
                    {
                        relations[i].grade = 0;
                    }
                }
                else
                {
                    relations[i].grade = 0;
                }
            }

            _repositorio.gradeCG = relations.Sum(a => a.grade);

            return View("ResultMC", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersEtrePresent(List<string> answers)
        {
            _repositorio.EtrePerfectCompleted = true;
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
                if (i < answers.Count)
                {
                    string selectedAnswer = answers[i];

                    relations[i].selectedItem = relations[i].answerList.FirstOrDefault(a => a.ToString() == selectedAnswer);

                    if (relations[i].selectedItem == relations[i].answer)
                    {
                        relations[i].grade = 1;
                    }
                    else
                    {
                        relations[i].grade = 0;
                    }
                }
                else
                {
                    relations[i].grade = 0;
                }
            }

            _repositorio.gradeEtrePresent = relations.Sum(a => a.grade);

            return View("ResultMC", relations);
        }



        public IActionResult Completed() 
        {
            return View();
        }
    }
}
