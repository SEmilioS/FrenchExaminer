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

        public IActionResult MCetrePresent()
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

                return View(relations);
            }
            return RedirectToAction("Completed");
        }

        public IActionResult Mcmonth()
        {
            if (!_repositorio.MonthCompleted)
            {
                var randomQuestions = _repositorio.getQuestionsMonth(10);
                var relations = _repositorio.getAnswersMonth(randomQuestions);

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

        public IActionResult Mcweek() 
        {
            if (!_repositorio.WeekCompleted)
            {
                var randomQuestions = _repositorio.getQuestionsWeek(10);
                var relations = _repositorio.getAnswersWeek(randomQuestions);

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

        public IActionResult McArticle()
        {
            if (!_repositorio.ArticleCompleted)
            {
                var randomQuestions = _repositorio.getQuestionsArticle(20);
                var relations = _repositorio.getAnswersArticle(randomQuestions);

                _repositorio.preguntas = null;
                _repositorio.preguntas = relations;

                return View(relations);
            }
            return RedirectToAction("Completed");
        }

        public IActionResult MCnumbers()
        {
            if (!_repositorio.NumberCompleted)
            {
                var randomQuestions = _repositorio.getQuestionsNumber(10);
                var relations = _repositorio.getAnswersNumber(randomQuestions);

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
        public IActionResult MCadjective()
        {
            if (!_repositorio.AdjetiveCompleted)
            {
                var randomQuestions = _repositorio.getQuestionsAdjetive(10);
                var relations = _repositorio.getAnswersAdjetive(randomQuestions);

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

        [HttpPost]
        public IActionResult ProcessAnswersWeek(List<string> answers)
        {
            _repositorio.WeekCompleted = true;
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

            _repositorio.gradeWeek = relations.Sum(a => a.grade);

            return View("ResultMC", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersMonth(List<string> answers)
        {
            _repositorio.MonthCompleted = true;
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

            _repositorio.gradeMonth = relations.Sum(a => a.grade);

            return View("ResultMC", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersArticle(List<string> answers)
        {
            _repositorio.ArticleCompleted = true;
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

            _repositorio.gradeArticle = relations.Sum(a => a.grade);

            return View("ResultMC", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersNumbers(List<string> answers)
        {
            _repositorio.NumberCompleted = true;
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

            _repositorio.gradeNumbers = relations.Sum(a => a.grade);

            return View("ResultMC", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersAdjetive(List<string> answers)
        {
            _repositorio.AdjetiveCompleted = true;
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

            _repositorio.gradeAdjetive = relations.Sum(a => a.grade);

            return View("ResultMC", relations);
        }

        public IActionResult Completed() 
        {
            return View();
        }
    }
}
