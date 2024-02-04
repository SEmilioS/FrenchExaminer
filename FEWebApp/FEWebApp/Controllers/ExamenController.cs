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

        public IActionResult RcDate()
        {
            if (!_repositorio.DateCompleted)
            {
                var randomQuestions = _repositorio.getQuestionDate();

                _repositorio.preguntas = null;
                _repositorio.preguntas = randomQuestions;
                var question = new List<Question>();
                question.Add(randomQuestions[0].question);

                return View(question);
            }
            return RedirectToAction("Completed");
        }

        public IActionResult RcNations()
        {
            if (!_repositorio.NationsCompleted)
            {
                var randomQuestions = _repositorio.getQuestionsNation(5);

                _repositorio.nations = null;
                _repositorio.nations = randomQuestions;

                return View(randomQuestions);
            }
            return RedirectToAction("Completed");
        }

        public IActionResult RcVocabulary()
        {
            if (!_repositorio.VocabularyCompleted)
            {
                var randomQuestions = _repositorio.getQuestionsVocabulary(10);
                var relations = _repositorio.getAnswersVocabulary(randomQuestions);

                _repositorio.preguntas = null;
                _repositorio.preguntas = relations;

                return View(relations);
            }
            return RedirectToAction("Completed");
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
                var randomQuestions = _repositorio.getQuestionsArticle(15);
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

        public IActionResult McLieu()
        {
            if (!_repositorio.LieuCompleted)
            {
                var randomQuestions = _repositorio.getQuestionsLieu(10);
                var relations = _repositorio.getAnswersLieu(randomQuestions);

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

        public IActionResult McFamily()
        {
            if (!_repositorio.FamilyCompleted)
            {
                var randomQuestions = _repositorio.getQuestionsFamily(10);
                var relations = _repositorio.getAnswersFamily(randomQuestions);

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
            var numberQuestions = 10;
            var typeCompleated = "Culture Generale";
            var relations = _repositorio.preguntas;
            relations = _repositorio.generateNotes(numberQuestions, typeCompleated, relations, answers);
            relations[0].NextAction = "MCetrePresent";

            return View("ResultMC", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersEtrePresent(List<string> answers)
        {
            var numberQuestions = 10;
            var typeCompleated = "Verbe Etre";
            var relations = _repositorio.preguntas;
            relations = _repositorio.generateNotes(numberQuestions, typeCompleated, relations, answers);
            relations[0].NextAction = "MCweek";

            return View("ResultMC", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersWeek(List<string> answers)
        {
            var numberQuestions = 10;
            var typeCompleated = "Jours de la Semaine";
            var relations = _repositorio.preguntas;
            relations = _repositorio.generateNotes(numberQuestions, typeCompleated, relations, answers);
            relations[0].NextAction = "MCmonth";

            return View("ResultMC", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersMonth(List<string> answers)
        {
            var numberQuestions = 10;
            var typeCompleated = "Mois de l'annee";
            var relations = _repositorio.preguntas;
            relations = _repositorio.generateNotes(numberQuestions, typeCompleated, relations, answers);
            relations[0].NextAction = "McArticle";

            return View("ResultMC", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersArticle(List<string> answers)
        {
            var numberQuestions = 15;
            var typeCompleated = "Articles definis et indefinis";
            var relations = _repositorio.preguntas;
            relations = _repositorio.generateNotes(numberQuestions, typeCompleated, relations, answers);
            relations[0].NextAction = "MCnumbers";

            return View("ResultMC", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersNumbers(List<string> answers)
        {
            var numberQuestions = 10;
            var typeCompleated = "Noms de chiffres de 0 a 69";
            var relations = _repositorio.preguntas;
            relations = _repositorio.generateNotes(numberQuestions, typeCompleated, relations, answers);
            relations[0].NextAction = "MCadjective";

            return View("ResultMC", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersAdjetive(List<string> answers)
        {
            var numberQuestions = 10;
            var typeCompleated = "Adjectifs qualificatifs";
            var relations = _repositorio.preguntas;
            relations = _repositorio.generateNotes(numberQuestions, typeCompleated, relations, answers);
            relations[0].NextAction = "McLieu";

            return View("ResultMC", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersLieu(List<string> answers)
        {
            var numberQuestions = 10;
            var typeCompleated = "Prepositions de Lieu";
            var relations = _repositorio.preguntas;
            relations = _repositorio.generateNotes(numberQuestions, typeCompleated, relations, answers);
            relations[0].NextAction = "McFamily";

            return View("ResultMC", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersFamily(List<string> answers)
        {
            var numberQuestions = 10;
            var typeCompleated = "Le Famille";
            var relations = _repositorio.preguntas;
            relations = _repositorio.generateNotes(numberQuestions, typeCompleated, relations, answers);
            relations[0].NextAction = "RcNations";

            return View("ResultMC", relations);
        }


        [HttpPost]
        public IActionResult ProcessAnswersNations(List<string> answers)
        {
            var numberQuestions = 5;
            var typeCompleated = "Les Nationalites";
            var nationsQ = _repositorio.nations;
            var relations = _repositorio.getAnswersNationality(nationsQ);
            relations = _repositorio.generateNotes(numberQuestions, typeCompleated, relations, answers);
            relations[0].NextAction = "RcVocabulary";

            return View("ResultNationality", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersVocabulary(List<string> answers)
        {
            var numberQuestions = 10;
            var typeCompleated = "Extre Vocabulaire";
            var relations = _repositorio.preguntas;
            relations = _repositorio.generateNotes(numberQuestions, typeCompleated, relations, answers);
            relations[0].NextAction = "RcDate";

            return View("ResultNationality", relations);
        }

        [HttpPost]
        public IActionResult ProcessAnswersDate(List<string> answers)
        {
            var numberQuestions = 1;
            var typeCompleated = "Le Date";
            var relations = _repositorio.getQuestionDate();
            relations = _repositorio.generateNotes(numberQuestions, typeCompleated, relations, answers);
            relations[0].NextAction = "Completed";

            return View("ResultNationality", relations);
        }
        public IActionResult Completed() 
        {
            return View();
        }
    }
}
