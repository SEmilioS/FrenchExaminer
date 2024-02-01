using FEWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FEWebApp.Data
{
    public class DB
    {
        private List<Question> _questionsCG = new List<Question>();
        private List<Question> _questionsEtre = new List<Question>();
        private List<Relation> _relations = new List<Relation>();
        private List<Answer> _answersEtrePresent = new List<Answer>();
        private List<Answer> _answerEtreFuture = new List<Answer>();
        private List<Answer> _answerEtreImperfect = new List<Answer>();
        private List<Answer> _answerEtrePresentNegative = new List<Answer>();
        private List<Answer> _answerEtrePastSimple = new List<Answer>();

        public List<Relation> preguntas = new List<Relation>();
        public int gradeCG = 0;
        public int gradeEtrePresent = 0;
        public bool CGcompleted = false;
        public bool EtrePerfectCompleted = false;

        public DB()
        {
            // Initialize the database with sample data
            InitializeData();
        }

        private void InitializeData()
        {
            // Sample Questions General Knolage
            var question1 = new Question { Id = 1, value = "Quel est le nom officiel de la France?" };
            var question2 = new Question { Id = 2, value = "Combien de régions la France est-elle divisée?" };
            var question3 = new Question { Id = 3, value = "Qui est le Président de la France?" };
            var question4 = new Question { Id = 4, value = "Qui est le Premier Ministre de la France?" };
            var question5 = new Question { Id = 5, value = "Quelle est la monnaie utilisée en France?" };
            var question6 = new Question { Id = 6, value = "Quelle est la monnaie utilisée en Amérique?" };
            var question7 = new Question { Id = 6, value = "Quelle est la monnaie utilisée au Japon?" };
            var question8 = new Question { Id = 7, value = "Quelle est la fete nationale de la France?" };
            var question9 = new Question { Id = 8, value = "Quel est l'oiseau national de la France?" };
            var question10 = new Question { Id = 9, value = "Quelle est la fleur nationale de la France?" };
            var question11 = new Question { Id = 10, value = "Quel est le monument emblématique de la France?" };
            var question12 = new Question { Id = 11, value = "Quels sont las pays limitrophes de la France?" };
            var question13 = new Question { Id = 12, value = "Quel est l'hymne national de la France?" };
            var question14 = new Question { Id = 13, value = "Quelles sont des spécialités culinaires francaises?" };

            //Samplae Questions Etre Present
            var question15 = new Question { Id = 15, value = "Tu ____ en France." };
            var question16 = new Question { Id = 16, value = "Il/Elle/On ____ fatigué." };
            var question17 = new Question { Id = 17, value = "Nous ____ contents." };
            var question18 = new Question { Id = 18, value = "Vous ____ à l'école." };
            var question19 = new Question { Id = 19, value = "Ils/Elles ____ là-bas." };
            var question20 = new Question { Id = 20, value = "Elle ____ médecin." };
            var question21 = new Question { Id = 21, value = "Nous ____ prêts." };
            var question22 = new Question { Id = 22, value = "Tu ____ fatiguée." };
            var question23 = new Question { Id = 23, value = "Je ____ professeur." };
            var question24 = new Question { Id = 24, value = "Il ____ en vacances." };
            var question25 = new Question { Id = 25, value = "Vous ____ dans la salle." };
            var question26 = new Question { Id = 26, value = "Elles ____ très occupées." };
            var question27 = new Question { Id = 27, value = "Nous ____ là-bas." };
            var question28 = new Question { Id = 28, value = "Il ____ à la maison." };
            var question29 = new Question { Id = 29, value = "Je ____ un étudiant." };
            var question30 = new Question { Id = 30, value = "Je/J'____ malade hier." };
            var question31 = new Question { Id = 31, value = "Je/J'____ en retard ce matin." };
            var question32 = new Question { Id = 32, value = "Je/J'____ heureux pendant les vacances." };
            var question33 = new Question { Id = 33, value = "Je/J'____ chez moi tout l'après-midi." };
            var question34 = new Question { Id = 34, value = "Je ____ à la plage hier." };
            var question35 = new Question { Id = 35, value = "Je/J'____ fatigué après le travail." };

            _questionsEtre.Add(question15);
            _questionsEtre.Add(question16);
            _questionsEtre.Add(question17);
            _questionsEtre.Add(question18);
            _questionsEtre.Add(question19);
            _questionsEtre.Add(question20);
            _questionsEtre.Add(question21);
            _questionsEtre.Add(question22);
            _questionsEtre.Add(question23);
            _questionsEtre.Add(question24);
            _questionsEtre.Add(question25);
            _questionsEtre.Add(question26);
            _questionsEtre.Add(question27);
            _questionsEtre.Add(question28);
            _questionsEtre.Add(question29);
            _questionsEtre.Add(question30);
            _questionsEtre.Add(question31);
            _questionsEtre.Add(question32);
            _questionsEtre.Add(question33);
            _questionsEtre.Add(question34);
            _questionsEtre.Add(question35);


            // Sample Answers Genearal knowlage
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
            var answer20 = new Answer { Id = 20, value = "14 juillet" };
            var answer21 = new Answer { Id = 21, value = "1er janvier" };
            var answer22 = new Answer { Id = 22, value = "25 décembre" };
            var answer23 = new Answer { Id = 23, value = "1er mai" };
            var answer24 = new Answer { Id = 24, value = "coq" };
            var answer25 = new Answer { Id = 25, value = "Cygne" };
            var answer26 = new Answer { Id = 26, value = "Aigle" };
            var answer27 = new Answer { Id = 27, value = "Colombe" };
            var answer28 = new Answer { Id = 28, value = "Lys" };
            var answer29 = new Answer { Id = 29, value = "Rose" };
            var answer30 = new Answer { Id = 30, value = "Tournesol" };
            var answer31 = new Answer { Id = 31, value = "Lilas" };
            var answer32 = new Answer { Id = 32, value = "Museo de Louvre" };
            var answer33 = new Answer { Id = 33, value = "Big Ben" };
            var answer34 = new Answer { Id = 34, value = "Tour de Pise" };
            var answer35 = new Answer { Id = 35, value = "Tour de Eiffel" };
            var answer36 = new Answer { Id = 36, value = "Espagne, Suisse, Belgique, Océan Atlantique" };
            var answer37 = new Answer { Id = 37, value = "Allemagne, Suisse, Belgique, Espagne" };
            var answer38 = new Answer { Id = 38, value = "Espagne, Allemagne, Italie, Rayoumeuni" };
            var answer39 = new Answer { Id = 39, value = "Suisse, belgique, Espagne, Italie" };
            var answer40 = new Answer { Id = 40, value = "La marseillaise" };
            var answer41 = new Answer { Id = 41, value = "Ode á la Joie" };
            var answer42 = new Answer { Id = 42, value = "God Save the King" };
            var answer43 = new Answer { Id = 43, value = "Hymne á la Beauté" };
            var answer44 = new Answer { Id = 44, value = "Vino, Queso, Crepas" };
            var answer45 = new Answer { Id = 45, value = "Burger, Fries, Shake" };
            var answer46 = new Answer { Id = 46, value = "Vino, Pasta, Dim Sum" };
            var answer47 = new Answer { Id = 47, value = "Gallo Pinto, Queso, Crepas" };

            //Sample Answers Verb to be Present //51,56,60,63,65,67
            var answer48 = new Answer { Id = 48, value = "suis" }; //je
            var answer49 = new Answer { Id = 49, value = "es" }; //Tu
            var answer50 = new Answer { Id = 50, value = "est" }; //Il or Elle
            var answer52 = new Answer { Id = 52, value = "sommes" }; //Nous
            var answer58 = new Answer { Id = 58, value = "êtes" }; //Vous
            var answer59 = new Answer { Id = 59, value = "sont" }; //Ills or Elles

            _answersEtrePresent.Add(answer48);
            _answersEtrePresent.Add(answer49);
            _answersEtrePresent.Add(answer50);
            _answersEtrePresent.Add(answer52);
            _answersEtrePresent.Add(answer58);
            _answersEtrePresent.Add(answer59);

            //Sample Answers Verb to be Future
            var answer53 = new Answer { Id = 53, value = "serai" }; //Je
            var answer54 = new Answer { Id = 54, value = "seras" }; //Tu
            var answer55 = new Answer { Id = 55, value = "sera" }; //Il or Elle
            var answer57 = new Answer { Id = 57, value = "serons" }; //Nous
            var answer61 = new Answer { Id = 61, value = "serez" }; //Vous
            var answer62 = new Answer { Id = 62, value = "seront" }; //Ils or Elles

            _answerEtreFuture.Add(answer53);
            _answerEtreFuture.Add(answer54);
            _answerEtreFuture.Add(answer55);
            _answerEtreFuture.Add(answer57);
            _answerEtreFuture.Add(answer61);
            _answerEtreFuture.Add(answer62);

            //Sample Answers Verb To be Past Imperfect
            var amswer64 = new Answer { Id = 64, value = "étais" }; //J' or Tu
            var answer66 = new Answer { Id = 66, value = "Il était" }; //Il or Elle
            var answer68 = new Answer { Id = 68, value = "étions" }; //Nous
            var answer69 = new Answer { Id = 69, value = "étiez" }; //Vous
            var answer70 = new Answer { Id = 70, value = "étaient" }; //Ils or Elles

            _answerEtreImperfect.Add(amswer64);
            _answerEtreImperfect.Add(answer66);
            _answerEtreImperfect.Add(answer68);
            _answerEtreImperfect.Add(answer69);
            _answerEtreImperfect.Add(answer70);

            //Sample Answers Verb to Be Present Simple Negative
            var answer71 = new Answer { Id = 71, value = "ne suis pas" }; // Je
            var answer72 = new Answer { Id = 72, value = "n'es pas" }; //Tu
            var answer73 = new Answer { Id = 73, value = "n'est past" }; //Il or Elle
            var answer74 = new Answer { Id = 74, value = "ne sommes pas" }; //nous
            var answer75 = new Answer { Id = 75, value = "n'êtes pas" }; //vous
            var answer76 = new Answer { Id = 76, value = "ne sont pas" }; //Ils or Elles

            _answerEtrePresentNegative.Add(answer71);
            _answerEtrePresentNegative.Add(answer72);
            _answerEtrePresentNegative.Add(answer73);
            _answerEtrePresentNegative.Add(answer74);
            _answerEtrePresentNegative.Add(answer75);
            _answerEtrePresentNegative.Add(answer76);

            //Sample Answers Verb to Be Past Simple
            var answer77 = new Answer { Id = 77, value = "fus" }; //je or tu
            var answer78 = new Answer { Id = 78, value = "fut" }; //il or elle
            var answer79 = new Answer { Id = 79, value = "fûmes" }; // nous
            var answer80 = new Answer { Id = 80, value = "fütes" }; //vous
            var answer81 = new Answer { Id = 81, value = "furent" }; //Ils or elles

            _answerEtrePastSimple.Add(answer77);
            _answerEtrePastSimple.Add(answer78);
            _answerEtrePastSimple.Add(answer79);
            _answerEtrePastSimple.Add(answer80);
            _answerEtrePastSimple.Add(answer81);


            // Sample Relations
            var relation1 = new Relation { question = question1, answer = answer1, answerList = new List<Answer> { answer6, answer7, answer8} };
            var relation2 = new Relation { question = question2, answer = answer2, answerList = new List<Answer> { answer9, answer10, answer11 } };
            var relation3 = new Relation { question = question3, answer = answer3, answerList = new List<Answer> { answer12, answer13, answer14 } };
            var relation4 = new Relation { question = question4, answer = answer4, answerList = new List<Answer> { answer12, answer16, answer3 } };
            var relation5 = new Relation { question = question5, answer = answer5, answerList = new List<Answer> { answer17, answer18, answer19 } };
            var relation6 = new Relation { question = question6, answer = answer17, answerList = new List<Answer> { answer5, answer18, answer19 } };
            var relation7 = new Relation { question = question7, answer = answer18, answerList = new List<Answer> { answer19, answer17, answer5 } };
            var relation8 = new Relation { question = question8, answer = answer20, answerList = new List<Answer> { answer21, answer22, answer23 } };
            var relation9 = new Relation { question = question9, answer = answer24, answerList = new List<Answer> { answer25, answer26, answer27 } };
            var relation10 = new Relation { question = question10, answer = answer28, answerList = new List<Answer> { answer29, answer30, answer31 } };
            var relation11 = new Relation { question = question11, answer = answer35, answerList = new List<Answer> { answer32, answer33, answer34 } };
            var relation12 = new Relation { question = question12, answer = answer36, answerList = new List<Answer> { answer37, answer38, answer39 } };
            var relation13 = new Relation { question = question13, answer = answer40, answerList = new List<Answer> { answer41, answer42, answer43 } };
            var relation14 = new Relation { question = question14, answer = answer44, answerList = new List<Answer> { answer45, answer46, answer47 } };

            var relation15 = new Relation { question = question15, answer = answer49, answerList = _answersEtrePresent };
            var relation16 = new Relation { question = question16, answer = answer50, answerList = _answersEtrePresent };
            var relation17 = new Relation { question = question17, answer = answer52, answerList = _answersEtrePresent };
            var relation18 = new Relation { question = question18, answer = answer58, answerList = _answersEtrePresent };
            var relation19 = new Relation { question = question19, answer = answer59, answerList = _answersEtrePresent };
            var relation20 = new Relation { question = question20, answer = answer50, answerList = _answersEtrePresent };
            var relation21 = new Relation { question = question21, answer = answer52, answerList = _answersEtrePresent };
            var relation22 = new Relation { question = question22, answer = answer49, answerList = _answersEtrePresent };
            var relation23 = new Relation { question = question23, answer = answer48, answerList = _answersEtrePresent };
            var relation24 = new Relation { question = question24, answer = answer50, answerList = _answersEtrePresent };
            var relation25 = new Relation { question = question25, answer = answer58, answerList = _answersEtrePresent };
            var relation26 = new Relation { question = question26, answer = answer59, answerList = _answersEtrePresent };
            var relation27 = new Relation { question = question27, answer = answer52, answerList = _answersEtrePresent };
            var relation28 = new Relation { question = question28, answer = answer50, answerList = _answersEtrePresent };
            var relation29 = new Relation { question = question29, answer = answer48, answerList = _answersEtrePresent };
            var relation30 = new Relation { question = question30, answer = answer48, answerList = _answersEtrePresent };
            var relation31 = new Relation { question = question31, answer = answer48, answerList = _answersEtrePresent };
            var relation32 = new Relation { question = question32, answer = answer48, answerList = _answersEtrePresent };
            var relation33 = new Relation { question = question33, answer = answer48, answerList = _answersEtrePresent };
            var relation34 = new Relation { question = question34, answer = answer48, answerList = _answersEtrePresent };
            var relation35 = new Relation { question = question35, answer = answer48, answerList = _answersEtrePresent };



            // Add questions, answers, and relations to the lists
            _questionsCG.Add(question1);
            _questionsCG.Add(question2);
            _questionsCG.Add(question3);
            _questionsCG.Add(question4);
            _questionsCG.Add(question5);
            _questionsCG.Add(question6);
            _questionsCG.Add(question7);
            _questionsCG.Add(question8);
            _questionsCG.Add(question9);
            _questionsCG.Add(question10);
            _questionsCG.Add(question11);
            _questionsCG.Add(question12);
            _questionsCG.Add(question13);
            _questionsCG.Add(question14);

            _relations.Add(relation1);
            _relations.Add(relation2);
            _relations.Add(relation3);
            _relations.Add(relation4);
            _relations.Add(relation5);
            _relations.Add(relation6);
            _relations.Add(relation7);
            _relations.Add(relation8);
            _relations.Add(relation9);
            _relations.Add(relation10);
            _relations.Add(relation11);
            _relations.Add(relation12);
            _relations.Add(relation13);
            _relations.Add(relation14);
            _relations.Add(relation15);
            _relations.Add(relation16);
            _relations.Add(relation17);
            _relations.Add(relation18);
            _relations.Add(relation19);
            _relations.Add(relation20);
            _relations.Add(relation21);
            _relations.Add(relation22);
            _relations.Add(relation23);
            _relations.Add(relation24);
            _relations.Add(relation25);
            _relations.Add(relation26);
            _relations.Add(relation27);
            _relations.Add(relation28);
            _relations.Add(relation29);
            _relations.Add(relation30);
            _relations.Add(relation31);
            _relations.Add(relation32);
            _relations.Add(relation33);
            _relations.Add(relation34);
            _relations.Add(relation35);

        }

        public List<Question> GetQuestionsCG(int quantity)
        {
            List<Question> selectedQuestions = new List<Question>();
            HashSet<Question> selectedQuestionSet = new HashSet<Question>();

            quantity = Math.Min(quantity, _questionsCG.Count);

            List<Question> shuffledQuestions = _questionsCG.OrderBy(q => Guid.NewGuid()).ToList();

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
                var questionDTO = _questionsCG.FirstOrDefault(q => q.ToString() == question.ToString());

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

        public List<Question> getQuestionsEtre(int quantity) 
        {
            List<Question> selectedQuestions = new List<Question>();
            HashSet<Question> selectedQuestionSet = new HashSet<Question>();

            quantity = Math.Min(quantity, _questionsEtre.Count);

            List<Question> shuffledQuestions = _questionsEtre.OrderBy(q => Guid.NewGuid()).ToList();

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

        public List<Relation> getAnswersEtrePresent(List<Question> questions)
        {
            List<Relation> result = new List<Relation>();

            foreach (var question in questions)
            {
                if (question.Id >= 15 && question.Id <= 35)
                {
                    var questionDTO = _questionsEtre.FirstOrDefault(q => q.ToString() == question.ToString());

                    if (questionDTO != null)
                    {
                        var relationDTO = _relations.FirstOrDefault(r => r.question?.Id == questionDTO.Id);

                        if (relationDTO != null)
                        {
                            result.Add(relationDTO);
                        }
                    }
                }
            }

            return result;
        }


    }
}
