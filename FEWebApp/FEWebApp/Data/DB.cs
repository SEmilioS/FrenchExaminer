using FEWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FEWebApp.Data
{
    public class DB
    {
        private List<Question> _questions = new List<Question>();
        private List<Answer> _answers = new List<Answer>();
        private List<Relation> _relations = new List<Relation>();

        public List<Relation> preguntas = new List<Relation>();

        public DB()
        {
            // Initialize the database with sample data
            InitializeData();
        }

        private void InitializeData()
        {
            // Sample Questions
            var question1 = new Question { Id = 1, value = "Quel est le nom officiel de la France?" };
            var question2 = new Question { Id = 2, value = "Combien de régions la France est-elle divisée?" };
            var question3 = new Question { Id = 3, value = "Qui est le Président de la France?" };
            var question4 = new Question { Id = 4, value = "Qui est le Premier Ministre de la France?" };
            var question5 = new Question { Id = 5, value = "Quelle est la monnaie utilisée en France?" };
            var question6 = new Question { Id = 6, value = "Quelle est la monnaie utilisée en Amérique?" };
            var question7 = new Question { Id = 6, value = "Quelle est la monnaie utilisée au Japon?" };

            // Sample Answers
            var answer1 = new Answer { Id = 1, value = "République Francaise" };
            var answer2 = new Answer { Id = 2, value = "18 régions" };
            var answer3 = new Answer { Id = 3, value = "Emmanuel Macron" };
            var answer4 = new Answer { Id = 4, value = "Elizabeth Borne" };
            var answer5 = new Answer { Id = 5, value = "Euro" };
            var answer6 = new Answer { Id = 6, value = "République Allemande" };
            var answer7 = new Answer { Id = 7, value = "République Costaricienne" };
            var answer8 = new Answer { Id = 8, value = "République Italiene" };
            var answer9 = new Answer { Id = 9, value = "10 Régions" };
            var answer10 = new Answer { Id = 10, value = "20 Régions" };
            var answer11 = new Answer { Id = 11, value = "15 Régions" };
            var answer12 = new Answer { Id = 12, value = "Angela Merkel" };
            var answer13 = new Answer { Id = 13, value = "Boris Johnson" };
            var answer14 = new Answer { Id = 14, value = "Joe Biden" };
            var answer16 = new Answer { Id = 16, value = "Justin Trudeau" };
            var answer17 = new Answer { Id = 17, value = "Dollar américain" };
            var answer18 = new Answer { Id = 18, value = "Yen japonais" };
            var answer19 = new Answer { Id = 19, value = "Livre sterling" };


            // Sample Relations
            var relation1 = new Relation { question = question1, answer = answer1, answerList = new List<Answer> { answer6, answer7, answer8} };
            var relation2 = new Relation { question = question2, answer = answer2, answerList = new List<Answer> { answer9, answer10, answer11 } };
            var relation3 = new Relation { question = question3, answer = answer3, answerList = new List<Answer> { answer12, answer13, answer14 } };
            var relation4 = new Relation { question = question4, answer = answer4, answerList = new List<Answer> { answer12, answer16, answer3 } };
            var relation5 = new Relation { question = question5, answer = answer5, answerList = new List<Answer> { answer17, answer18, answer19 } };
            var relation6 = new Relation { question = question6, answer = answer17, answerList = new List<Answer> { answer5, answer18, answer19 } };
            var relation7 = new Relation { question = question7, answer = answer18, answerList = new List<Answer> { answer19, answer17, answer5 } };

            // Add questions, answers, and relations to the lists
            _questions.Add(question1);
            _questions.Add(question2);
            _questions.Add(question3);
            _questions.Add(question4);
            _questions.Add(question5);
            _questions.Add(question6);
            _questions.Add(question7);

            _relations.Add(relation1);
            _relations.Add(relation2);
            _relations.Add(relation3);
            _relations.Add(relation4);
            _relations.Add(relation5);
            _relations.Add(relation6);
            _relations.Add(relation7);

        }

        public List<Question> GetQuestions(int quantity)
        {
            List<Question> selectedQuestions = new List<Question>();
            HashSet<Question> selectedQuestionSet = new HashSet<Question>();

            quantity = Math.Min(quantity, _questions.Count);

            List<Question> shuffledQuestions = _questions.OrderBy(q => Guid.NewGuid()).ToList();

            for (int i = 0; i < shuffledQuestions.Count && selectedQuestions.Count < quantity; i++)
            {
                Question question = shuffledQuestions[i];

                if (selectedQuestionSet.Add(question))
                {
                    selectedQuestions.Add(question);
                }
            }

            return selectedQuestions;
        }


        public List<Relation> getAnswers(List<Question> questions)
        {
            List<Relation> result = new List<Relation>();

            foreach (var question in questions)
            {
                var questionDTO = _questions.FirstOrDefault(q => q.ToString() == question.ToString());

                if (questionDTO != null)
                {
                    var relationDTO = _relations.FirstOrDefault(r => r.question?.Id == questionDTO.Id);

                    if (relationDTO != null)
                    {
                        result.Add(relationDTO);
                    }
                }
            }

            return result;
        }

    }
}
