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

        public List<string> GetQuestions(int quantity)
        {
            List<string> selectedQuestions = new List<string>();
            HashSet<string> selectedQuestionSet = new HashSet<string>();

            quantity = Math.Min(quantity, _questions.Count);

            List<Question> shuffledQuestions = _questions.OrderBy(q => Guid.NewGuid()).ToList();

            for (int i = 0; i < shuffledQuestions.Count && selectedQuestions.Count < quantity; i++)
            {
                string questionText = shuffledQuestions[i].ToString();

                if (selectedQuestionSet.Add(questionText))
                {
                    selectedQuestions.Add(questionText);
                }
            }

            return selectedQuestions;
        }

        public List<String> getAnswers(String question) {
            int minListSize = 4;
            var questionDTO = _questions.FirstOrDefault(q => q.ToString() == question);
            var relationDTO = _relations.FirstOrDefault(r => r.question.Id == questionDTO.Id);
            var answerDTO = _answers.FirstOrDefault(a => a.Id == relationDTO.answer.Id);

            List<string> answerList = new List<string>(minListSize);
            HashSet<string> answerListSet = new HashSet<string>(minListSize);

            answerList.Add(answerDTO.ToString());
            int minAnswerQuantity = 3;

            List<Answer> shuffledAnswers = _answers.OrderBy(q => Guid.NewGuid()).ToList();

            for (int i = 0; i < shuffledAnswers.Count && answerList.Count < minAnswerQuantity; i++)
            { 
                string answertext = shuffledAnswers[i].ToString();

                if (answerListSet.Add(answertext))
                { 
                    answerList.Add(answertext);
                }
            
            }

            return answerList;
        
        }
    }
}
