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
        private List<Question> _questionsWeek = new List<Question>();
        private List<Question> _questionMonth = new List<Question>();
        private List<Question> _questionArticle = new List<Question>();
        private List<Question> _questionNumbers = new List<Question>();
        private List<Question> _questionAdjetive = new List<Question>();
        private List<Question> _questionLieu = new List<Question>();
        private List<Relation> _relations = new List<Relation>();
        private List<Answer> _answersEtrePresent = new List<Answer>();
        private List<Answer> _answerJoursSemaine = new List<Answer>();
        private List<Answer> _answersMonths = new List<Answer>();
        private List<Answer> _answersArticle = new List<Answer>();
        private List<Answer> _answersNumbers = new List<Answer>();
        private List<Answer> _answersLieu = new List<Answer>();

        public List<Relation> preguntas = new List<Relation>();
        public int gradeCG = 0;
        public int gradeEtrePresent = 0;
        public int gradeWeek = 0;
        public int gradeMonth = 0;
        public int gradeArticle = 0;
        public int gradeNumbers = 0;
        public int gradeAdjetive = 0;
        public int gradeLieu = 0;
        public bool CGcompleted = false;
        public bool EtrePerfectCompleted = false;
        public bool WeekCompleted = false;
        public bool MonthCompleted = false;
        public bool ArticleCompleted = false;
        public bool NumberCompleted = false;
        public bool AdjetiveCompleted = false;
        public bool LieuCompleted = false;

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
            var question6 = new Question { Id = 6, value = "Quelle est la capitale de la France?" };
            var question7 = new Question { Id = 7, value = "Quelles sont les couleurs du drapeau français?" };
            var question8 = new Question { Id = 8, value = "Quelle est la fete nationale de la France?" };
            var question9 = new Question { Id = 9, value = "Quel est l'oiseau national de la France?" };
            var question10 = new Question { Id = 10, value = "Quelle est la fleur nationale de la France?" };
            var question11 = new Question { Id = 11, value = "Quel est le monument emblématique de la France?" };
            var question12 = new Question { Id = 12, value = "Quels sont las pays limitrophes de la France?" };
            var question13 = new Question { Id = 13, value = "Quel est l'hymne national de la France?" };
            var question14 = new Question { Id = 14, value = "Quelles sont des spécialités culinaires francaises?" };

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

            //Sample questions, days of the week
            var question36 = new Question { Id = 36, value = "Comment dit-on 'Lunes' en français ?" };
            var question37 = new Question { Id = 37, value = "Comment dit-on 'Martes' en français ?" };
            var question38 = new Question { Id = 38, value = "Comment dit-on 'Miercoles' en français ?" };
            var question39 = new Question { Id = 39, value = "Comment dit-on 'Jueves' en français ?" };
            var question40 = new Question { Id = 40, value = "Comment dit-on 'Viernes' en français ?" };
            var question41 = new Question { Id = 41, value = "Comment dit-on 'Sabado' en français ?" };
            var question42 = new Question { Id = 42, value = "Comment dit-on 'Domingo' en français ?" };
            var question44 = new Question { Id = 44, value = "Comment dit-on 'Hoy es Miercoles' en français ?" };
            var question45 = new Question { Id = 45, value = "Comment dit-on 'Mañana es Sabado' en français ?" };
            var question46 = new Question { Id = 46, value = "Comment dit-on 'Ayer era lunes' en français ?" };

            //Sample questions, months of the year
            var question47 = new Question { Id = 47, value = "Comment dit-on 'Enero' en français ?" };
            var question48 = new Question { Id = 48, value = "Comment dit-on 'Febrero' en français ?" };
            var question49 = new Question { Id = 49, value = "Comment dit-on 'Marzo' en français ?" };
            var question50 = new Question { Id = 50, value = "Comment dit-on 'Abril' en français ?" };
            var question51 = new Question { Id = 51, value = "Comment dit-on 'Mayo' en français ?" };
            var question52 = new Question { Id = 52, value = "Comment dit-on 'Junio' en français ?" };
            var question53 = new Question { Id = 53, value = "Comment dit-on 'Julio' en français ?" };
            var question54 = new Question { Id = 54, value = "Comment dit-on 'Agosto' en français ?" };
            var question55 = new Question { Id = 55, value = "Comment dit-on 'Septiembre' en français ?" };
            var question56 = new Question { Id = 56, value = "Comment dit-on 'Octubre' en français ?" };
            var question57 = new Question { Id = 57, value = "Comment dit-on 'Noviembre' en français ?" };
            var question58 = new Question { Id = 58, value = "Comment dit-on 'Diciembre' en français ?" };

            //Sample questions, Articles definites and indefinites
            var question59 = new Question { Id = 59, value = "Quel est ____ nom français pour 'chaise'?" };
            var question60 = new Question { Id = 60, value = "Comment dit-on 'lake' en français? ____ réponse commence par 'l.'" };
            var question61 = new Question { Id = 61, value = "Quel est ____ contraire de 'femme'?" };
            var question62 = new Question { Id = 62, value = "Donne-moi ____ noms des mois de l'année." };
            var question63 = new Question { Id = 63, value = "Quel article indéfini doit-on utiliser devant le mot 'éléphant'?" };
            var question64 = new Question { Id = 64, value = "Complète la phrase : 'J'ai vu ____ petite maison dans ____ village.'" };
            var question65 = new Question { Id = 65, value = "Donne ____ exemple d'un fruit qui commence par la lettre 'p'." };
            var question66 = new Question { Id = 66, value = "Trouve ____ synonyme pour ____ mot dans cette phrase : 'C'est ____ film intéressant.'" };
            var question67 = new Question { Id = 67, value = "Quel est ____ traduction française de 'soleil'?" };
            var question68 = new Question { Id = 68, value = "Donne-moi ____ adjectif qui commence par 'l'." };
            var question69 = new Question { Id = 69, value = "Trouve ____ nom d'une ville en France qui commence par 'P'." };
            var question70 = new Question { Id = 70, value = "Complète la phrase : 'J'ai visité ____ Tour Eiffel à Paris.'" };
            var question71 = new Question { Id = 71, value = "Quel article indéfini doit-on utiliser devant le mot 'amie'?" };
            var question72 = new Question { Id = 72, value = "Trouve ____ adjectif qui commence par 'd'." };
            var question73 = new Question { Id = 73, value = "Donne ____ exemple d'un instrument de musique." };
            var question74 = new Question { Id = 74, value = "Complète la phrase : 'J'ai acheté ____ robe pour ____ soirée.'" };

            //Sample questions, numbers from 0 to 69
            var question75 = new Question { Id = 75, value = "Comment écrit-on 0 en français ?" };
            var question76 = new Question { Id = 76, value = "Comment écrit-on 1 en français ?" };
            var question77 = new Question { Id = 77, value = "Comment écrit-on 2 en français ?" };
            var question78 = new Question { Id = 78, value = "Comment écrit-on 3 en français ?" };
            var question79 = new Question { Id = 79, value = "Comment écrit-on 4 en français ?" };
            var question80 = new Question { Id = 80, value = "Comment écrit-on 5 en français ?" };
            var question81 = new Question { Id = 81, value = "Comment écrit-on 6 en français ?" };
            var question82 = new Question { Id = 82, value = "Comment écrit-on 7 en français ?" };
            var question83 = new Question { Id = 83, value = "Comment écrit-on 8 en français ?" };
            var question84 = new Question { Id = 84, value = "Comment écrit-on 9 en français ?" };
            var question85 = new Question { Id = 85, value = "Comment écrit-on 10 en français ?" };
            var question86 = new Question { Id = 86, value = "Comment écrit-on 20 en français ?" };
            var question87 = new Question { Id = 87, value = "Comment écrit-on 30 en français ?" };
            var question88 = new Question { Id = 88, value = "Comment écrit-on 40 en français ?" };
            var question89 = new Question { Id = 89, value = "Comment écrit-on 50 en français ?" };
            var question90 = new Question { Id = 90, value = "Comment écrit-on 60 en français ?" };
            var question91 = new Question { Id = 91, value = "Comment écrit-on 11 en français ?" };
            var question92 = new Question { Id = 92, value = "Comment écrit-on 12 en français ?" };
            var question93 = new Question { Id = 93, value = "Comment écrit-on 13 en français ?" };
            var question94 = new Question { Id = 94, value = "Comment écrit-on 14 en français ?" };
            var question95 = new Question { Id = 95, value = "Comment écrit-on 15 en français ?" };
            var question96 = new Question { Id = 96, value = "Comment écrit-on 16 en français ?" };
            var question97 = new Question { Id = 97, value = "Comment écrit-on 17 en français ?" };
            var question98 = new Question { Id = 98, value = "Comment écrit-on 18 en français ?" };
            var question99 = new Question { Id = 99, value = "Comment écrit-on 19 en français ?" };
            var question100 = new Question { Id = 100, value = "Comment écrit-on 21 en français ?" };
            var question101 = new Question { Id = 101, value = "Comment écrit-on 22 en français ?" };
            var question102 = new Question { Id = 102, value = "Comment écrit-on 23 en français ?" };
            var question103 = new Question { Id = 103, value = "Comment écrit-on 24 en français ?" };
            var question104 = new Question { Id = 104, value = "Comment écrit-on 25 en français ?" };
            var question105 = new Question { Id = 105, value = "Comment écrit-on 26 en français ?" };
            var question106 = new Question { Id = 106, value = "Comment écrit-on 27 en français ?" };
            var question107 = new Question { Id = 107, value = "Comment écrit-on 28 en français ?" };
            var question108 = new Question { Id = 108, value = "Comment écrit-on 29 en français ?" };
            var question109 = new Question { Id = 109, value = "Comment écrit-on 31 en français ?" };
            var question110 = new Question { Id = 110, value = "Comment écrit-on 32 en français ?" };
            var question111 = new Question { Id = 111, value = "Comment écrit-on 33 en français ?" };
            var question112 = new Question { Id = 112, value = "Comment écrit-on 34 en français ?" };
            var question113 = new Question { Id = 113, value = "Comment écrit-on 35 en français ?" };
            var question114 = new Question { Id = 114, value = "Comment écrit-on 36 en français ?" };
            var question115 = new Question { Id = 115, value = "Comment écrit-on 37 en français ?" };
            var question116 = new Question { Id = 116, value = "Comment écrit-on 38 en français ?" };
            var question117 = new Question { Id = 117, value = "Comment écrit-on 39 en français ?" };
            var question118 = new Question { Id = 118, value = "Comment écrit-on 41 en français ?" };
            var question119 = new Question { Id = 119, value = "Comment écrit-on 42 en français ?" };
            var question120 = new Question { Id = 120, value = "Comment écrit-on 43 en français ?" };
            var question121 = new Question { Id = 121, value = "Comment écrit-on 44 en français ?" };
            var question122 = new Question { Id = 122, value = "Comment écrit-on 45 en français ?" };
            var question123 = new Question { Id = 123, value = "Comment écrit-on 46 en français ?" };
            var question124 = new Question { Id = 124, value = "Comment écrit-on 47 en français ?" };
            var question125 = new Question { Id = 125, value = "Comment écrit-on 48 en français ?" };
            var question126 = new Question { Id = 126, value = "Comment écrit-on 49 en français ?" };
            var question127 = new Question { Id = 127, value = "Comment écrit-on 51 en français ?" };
            var question128 = new Question { Id = 128, value = "Comment écrit-on 52 en français ?" };
            var question129 = new Question { Id = 129, value = "Comment écrit-on 53 en français ?" };
            var question130 = new Question { Id = 130, value = "Comment écrit-on 54 en français ?" };
            var question131 = new Question { Id = 131, value = "Comment écrit-on 55 en français ?" };
            var question132 = new Question { Id = 132, value = "Comment écrit-on 56 en français ?" };
            var question133 = new Question { Id = 133, value = "Comment écrit-on 57 en français ?" };
            var question134 = new Question { Id = 134, value = "Comment écrit-on 58 en français ?" };
            var question135 = new Question { Id = 135, value = "Comment écrit-on 59 en français ?" };
            var question136 = new Question { Id = 136, value = "Comment écrit-on 61 en français ?" };
            var question137 = new Question { Id = 137, value = "Comment écrit-on 62 en français ?" };
            var question138 = new Question { Id = 138, value = "Comment écrit-on 63 en français ?" };
            var question139 = new Question { Id = 139, value = "Comment écrit-on 64 en français ?" };
            var question140 = new Question { Id = 140, value = "Comment écrit-on 65 en français ?" };
            var question141 = new Question { Id = 141, value = "Comment écrit-on 66 en français ?" };
            var question142 = new Question { Id = 142, value = "Comment écrit-on 67 en français ?" };
            var question143 = new Question { Id = 143, value = "Comment écrit-on 68 en français ?" };
            var question144 = new Question { Id = 144, value = "Comment écrit-on 69 en français ?" };

            //Sample questions, adjective qualificatif
            var question145 = new Question { Id = 145, value = "Cet animal est très ____. (masculin)" };
            var question146 = new Question { Id = 146, value = "Cet animal est très ____. (féminin)" };
            var question147 = new Question { Id = 147, value = "Cette personne est très ____. (masculin)" };
            var question148 = new Question { Id = 148, value = "Cette personne est très ____. (féminin)" };
            var question149 = new Question { Id = 149, value = "Le livre est très ____. (masculin)" };
            var question150 = new Question { Id = 150, value = "Le livre est très ____. (féminin)" };
            var question151 = new Question { Id = 151, value = "La voiture est très ____. (masculin)" };
            var question152 = new Question { Id = 152, value = "La voiture est très ____. (féminin)" };
            var question153 = new Question { Id = 153, value = "Ce bâtiment est très ____. (masculin)" };
            var question154 = new Question { Id = 154, value = "Ce bâtiment est très ____. (féminin)" };

            //Sample question for Prepositions of lengh
            var question155 = new Question { Id = 155, value = "Le stylo est ____ la table. (en)" };
            var question156 = new Question { Id = 156, value = "Le chat est ____ la chaise. (sobre)" };
            var question157 = new Question { Id = 157, value = "Le livre est ____ la bibliothèque. (bajo)" };
            var question158 = new Question { Id = 158, value = "La télévision est ____ moi. (delante)" };
            var question159 = new Question { Id = 159, value = "Le vélo est ____ la maison. (detrás)" };
            var question160 = new Question { Id = 160, value = "Les clés sont ____ le tiroir. (dentro)" };
            var question161 = new Question { Id = 161, value = "Le restaurant est ____ l'épicerie. (cerca de)" };
            var question162 = new Question { Id = 162, value = "La plage est ____ la ville. (lejos de)" };
            var question163 = new Question { Id = 163, value = "La poste est ____ l'école. (frente a)" };
            var question164 = new Question { Id = 164, value = "Le parc est ____ la bibliothèque. (al lado de)" };
            var question165 = new Question { Id = 165, value = "Le monument est ____ les deux rues. (en medio de)" };
            var question166 = new Question { Id = 166, value = "____ les deux bâtiments, il y a un jardin. (entre)" };
            var question167 = new Question { Id = 167, value = "Le colis est ____ la porte. (a la par de)" };
            var question168 = new Question { Id = 168, value = "Il est ____ le vent. (contra)" };







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

            //Sample Answers, culture general
            var answer60 = new Answer { Id = 60, value = "bleu, blanc, rouge" };
            var answer61 = new Answer { Id = 61, value = "rouge, vert, jaune" };
            var answer62 = new Answer { Id = 62, value = "jaune, blanc, vert" };
            var answer63 = new Answer { Id = 63, value = "rouge, blanc" };
            var answer64 = new Answer { Id = 64, value = "San José" };
            var answer65 = new Answer { Id = 65, value = "Paris" };
            var answer66 = new Answer { Id = 66, value = "Athenes" };
            var answer67 = new Answer { Id = 67, value = "Hanoï" };

            //Sample answers days of the week
            var answer68 = new Answer { Id = 68, value = "Lundi" };
            var answer69 = new Answer { Id = 69, value = "Mardi" };
            var answer70 = new Answer { Id = 70, value = "Mercredi" };
            var answer71 = new Answer { Id = 71, value = "Jeudi" };
            var answer72 = new Answer { Id = 72, value = "Vendredi" };
            var answer73 = new Answer { Id = 73, value = "Samedi" };
            var answer74 = new Answer { Id = 74, value = "Dimanche" };
            var answer76 = new Answer { Id = 76, value = "Aujourd'hui c'est mercredi" };
            var answer77 = new Answer { Id = 77, value = "Demain c'est samedi" };
            var answer78 = new Answer { Id = 78, value = "Hier c'était lundi" };
            var answer79 = new Answer { Id = 76, value = "Aujourd'hui c'est jeudi" };
            var answer80 = new Answer { Id = 80, value = "Aujourd'hui c'est dimanche" };
            var answer81 = new Answer { Id = 81, value = "Aujourd'hui c'est lundi" };
            var answer82 = new Answer { Id = 82, value = "Demain c'est vendredi" };
            var answer83 = new Answer { Id = 83, value = "Demain c'est dimanche" };
            var answer84 = new Answer { Id = 84, value = "Demain c'est lundi" };
            var answer85 = new Answer { Id = 85, value = "Hier c'était mardi" };
            var answer86 = new Answer { Id = 86, value = "Hier c'était vendredi" };
            var answer87 = new Answer { Id = 87, value = "Hier c'était miercoles :v" };

            //Sample answers months of the year
            var answer88 = new Answer { Id = 88, value = "Janvier" };
            var answer89 = new Answer { Id = 89, value = "Février" };
            var answer90 = new Answer { Id = 90, value = "Mars" };
            var answer91 = new Answer { Id = 91, value = "Avril" };
            var answer92 = new Answer { Id = 92, value = "Mai" };
            var answer93 = new Answer { Id = 93, value = "Juin" };
            var answer94 = new Answer { Id = 94, value = "Juillet" };
            var answer95 = new Answer { Id = 95, value = "Août" };
            var answer96 = new Answer { Id = 96, value = "Septembre" };
            var answer97 = new Answer { Id = 97, value = "Octobre" };
            var answer98 = new Answer { Id = 98, value = "Novembre" };
            var answer99 = new Answer { Id = 99, value = "Décembre" };

            //Sample answers articles definites and indefinites
            var answer101 = new Answer { Id = 101, value = "l'" };
            var answer102 = new Answer { Id = 102, value = "le" };
            var answer103 = new Answer { Id = 103, value = "les" };
            var answer104 = new Answer { Id = 104, value = "la" };
            var answer105 = new Answer { Id = 105, value = "un" };
            var answer106 = new Answer { Id = 106, value = "une" };
            var answer107 = new Answer { Id = 107, value = "des" };
            var answer108 = new Answer { Id = 108, value = "une" };

            //Sample answers numbers from 0 to 69
            var answer109 = new Answer { Id = 109, value = "zéro" };
            var answer110 = new Answer { Id = 110, value = "un" };
            var answer111 = new Answer { Id = 111, value = "deux" };
            var answer112 = new Answer { Id = 112, value = "trois" };
            var answer113 = new Answer { Id = 113, value = "quatre" };
            var answer114 = new Answer { Id = 114, value = "cinq" };
            var answer115 = new Answer { Id = 115, value = "six" };
            var answer116 = new Answer { Id = 116, value = "sept" };
            var answer117 = new Answer { Id = 117, value = "huit" };
            var answer118 = new Answer { Id = 118, value = "neuf" };
            var answer119 = new Answer { Id = 119, value = "dix" };
            var answer120 = new Answer { Id = 120, value = "vingt" };
            var answer121 = new Answer { Id = 121, value = "trente" };
            var answer122 = new Answer { Id = 122, value = "quarante" };
            var answer123 = new Answer { Id = 123, value = "cinquante" };
            var answer124 = new Answer { Id = 124, value = "soixante" };
            var answer125 = new Answer { Id = 125, value = "onze" };
            var answer126 = new Answer { Id = 126, value = "douze" };
            var answer127 = new Answer { Id = 127, value = "treize" };
            var answer128 = new Answer { Id = 128, value = "quatorze" };
            var answer129 = new Answer { Id = 129, value = "quinze" };
            var answer130 = new Answer { Id = 130, value = "seize" };
            var answer131 = new Answer { Id = 131, value = "dix-sept" };
            var answer132 = new Answer { Id = 132, value = "dix-huit" };
            var answer133 = new Answer { Id = 133, value = "dix-neuf" };
            var answer134 = new Answer { Id = 134, value = "vingt et un" };
            var answer135 = new Answer { Id = 135, value = "vingt-deux" };
            var answer136 = new Answer { Id = 136, value = "vingt-trois" };
            var answer137 = new Answer { Id = 137, value = "vingt-quatre" };
            var answer138 = new Answer { Id = 138, value = "vingt-cinq" };
            var answer139 = new Answer { Id = 139, value = "vingt-six" };
            var answer140 = new Answer { Id = 140, value = "vingt-sept" };
            var answer141 = new Answer { Id = 141, value = "vingt-huit" };
            var answer142 = new Answer { Id = 142, value = "vingt-neuf" };
            var answer143 = new Answer { Id = 143, value = "trente et un" };
            var answer144 = new Answer { Id = 144, value = "trente-deux" };
            var answer145 = new Answer { Id = 145, value = "trente-trois" };
            var answer146 = new Answer { Id = 146, value = "trente-quatre" };
            var answer147 = new Answer { Id = 147, value = "trente-cinq" };
            var answer148 = new Answer { Id = 148, value = "trente-six" };
            var answer149 = new Answer { Id = 149, value = "trente-sept" };
            var answer150 = new Answer { Id = 150, value = "trente-huit" };
            var answer151 = new Answer { Id = 151, value = "trente-neuf" };
            var answer152 = new Answer { Id = 152, value = "quarante et un" };
            var answer153 = new Answer { Id = 153, value = "quarante-deux" };
            var answer154 = new Answer { Id = 154, value = "quarante-trois" };
            var answer155 = new Answer { Id = 155, value = "quarante-quatre" };
            var answer156 = new Answer { Id = 156, value = "quarante-cinq" };
            var answer157 = new Answer { Id = 157, value = "quarante-six" };
            var answer158 = new Answer { Id = 158, value = "quarante-sept" };
            var answer159 = new Answer { Id = 159, value = "quarante-huit" };
            var answer160 = new Answer { Id = 160, value = "quarante-neuf" };
            var answer161 = new Answer { Id = 161, value = "cinquante et un" };
            var answer162 = new Answer { Id = 162, value = "cinquante-deux" };
            var answer163 = new Answer { Id = 163, value = "cinquante-trois" };
            var answer164 = new Answer { Id = 164, value = "cinquante-quatre" };
            var answer165 = new Answer { Id = 165, value = "cinquante-cinq" };
            var answer166 = new Answer { Id = 166, value = "cinquante-six" };
            var answer167 = new Answer { Id = 167, value = "cinquante-sept" };
            var answer168 = new Answer { Id = 168, value = "cinquante-huit" };
            var answer169 = new Answer { Id = 169, value = "cinquante-neuf" };
            var answer170 = new Answer { Id = 170, value = "soixante et un" };
            var answer171 = new Answer { Id = 171, value = "soixante-deux" };
            var answer172 = new Answer { Id = 172, value = "soixante-trois" };
            var answer173 = new Answer { Id = 173, value = "soixante-quatre" };
            var answer174 = new Answer { Id = 174, value = "soixante-cinq" };
            var answer175 = new Answer { Id = 175, value = "soixante-six" };
            var answer176 = new Answer { Id = 176, value = "soixante-sept" };
            var answer177 = new Answer { Id = 177, value = "soixante-huit" };
            var answer178 = new Answer { Id = 178, value = "soixante-neuf" };

            //Sample answers adjetives
            var answer179 = new Answer { Id = 179, value = "grand" };
            var answer180 = new Answer { Id = 180, value = "heureux" };
            var answer181 = new Answer { Id = 181, value = "coloré" };
            var answer182 = new Answer { Id = 182, value = "veuf" };
            var answer183 = new Answer { Id = 183, value = "intéressant" };
            var answer184 = new Answer { Id = 184, value = "élégant" };

            var answer185 = new Answer { Id = 185, value = "grande" };
            var answer186 = new Answer { Id = 186, value = "heureuse" };
            var answer187 = new Answer { Id = 187, value = "colorée" };
            var answer188 = new Answer { Id = 188, value = "veuve" };
            var answer189 = new Answer { Id = 189, value = "intéressante" };
            var answer190 = new Answer { Id = 190, value = "élégante" };

            //Sample answers prepositions de lieu
            var answer191 = new Answer { Id = 191, value = "sur" };
            var answer192 = new Answer { Id = 192, value = "sous" };
            var answer193 = new Answer { Id = 193, value = "dans" };
            var answer194 = new Answer { Id = 194, value = "devant" };
            var answer195 = new Answer { Id = 195, value = "derrière" };
            var answer196 = new Answer { Id = 196, value = "à côté de" };
            var answer197 = new Answer { Id = 197, value = "au milieu de" };
            var answer198 = new Answer { Id = 198, value = "entre" };
            var answer199 = new Answer { Id = 199, value = "près de" };
            var answer200 = new Answer { Id = 200, value = "loin de" };
            var answer201 = new Answer { Id = 201, value = "en face de" };
            var answer202 = new Answer { Id = 202, value = "contre" };
            var answer203 = new Answer { Id = 203, value = "par" };
            var answer204 = new Answer { Id = 204, value = "à" };



            // Sample Relations
            var relation1 = new Relation { question = question1, answer = answer1, answerList = new List<Answer> { answer6, answer7, answer8} };
            var relation2 = new Relation { question = question2, answer = answer2, answerList = new List<Answer> { answer9, answer10, answer11 } };
            var relation3 = new Relation { question = question3, answer = answer3, answerList = new List<Answer> { answer12, answer13, answer14 } };
            var relation4 = new Relation { question = question4, answer = answer4, answerList = new List<Answer> { answer12, answer16, answer3 } };
            var relation5 = new Relation { question = question5, answer = answer5, answerList = new List<Answer> { answer17, answer18, answer19 } };
            var relation6 = new Relation { question = question7, answer = answer60, answerList = new List<Answer> { answer61, answer62, answer63 } };
            var relation7 = new Relation { question = question6, answer = answer65, answerList = new List<Answer> { answer64, answer66, answer67 } };
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

            var relation36 = new Relation { question = question36, answer = answer68, answerList = _answerJoursSemaine };
            var relation37 = new Relation { question = question37, answer = answer69, answerList = _answerJoursSemaine };
            var relation38 = new Relation { question = question38, answer = answer70, answerList = _answerJoursSemaine };
            var relation39 = new Relation { question = question39, answer = answer71, answerList = _answerJoursSemaine };
            var relation40 = new Relation { question = question40, answer = answer72, answerList = _answerJoursSemaine };
            var relation41 = new Relation { question = question41, answer = answer73, answerList = _answerJoursSemaine };
            var relation42 = new Relation { question = question42, answer = answer74, answerList = _answerJoursSemaine };
            var relation43 = new Relation { question = question44, answer = answer76, answerList = new List<Answer> { answer79, answer80, answer81 } };
            var relation44 = new Relation { question = question45, answer = answer77, answerList = new List<Answer> { answer82, answer83, answer84 } };
            var relation45 = new Relation { question = question46, answer = answer78, answerList = new List<Answer> { answer85, answer86, answer87 } };

            var relation46 = new Relation { question = question47, answer = answer88, answerList = _answersMonths };
            var relation47 = new Relation { question = question48, answer = answer89, answerList = _answersMonths };
            var relation48 = new Relation { question = question49, answer = answer90, answerList = _answersMonths };
            var relation49 = new Relation { question = question50, answer = answer91, answerList = _answersMonths };
            var relation50 = new Relation { question = question51, answer = answer92, answerList = _answersMonths };
            var relation51 = new Relation { question = question52, answer = answer93, answerList = _answersMonths };
            var relation52 = new Relation { question = question53, answer = answer94, answerList = _answersMonths };
            var relation53 = new Relation { question = question54, answer = answer95, answerList = _answersMonths };
            var relation54 = new Relation { question = question55, answer = answer96, answerList = _answersMonths };
            var relation55 = new Relation { question = question56, answer = answer97, answerList = _answersMonths };
            var relation56 = new Relation { question = question57, answer = answer98, answerList = _answersMonths };
            var relation57 = new Relation { question = question58, answer = answer99, answerList = _answersMonths };

            var relation59 = new Relation { question = question59, answer = answer101, answerList = _answersArticle };
            var relation60 = new Relation { question = question60, answer = answer102, answerList = _answersArticle };
            var relation61 = new Relation { question = question61, answer = answer103, answerList = _answersArticle };
            var relation62 = new Relation { question = question62, answer = answer104, answerList = _answersArticle };
            var relation63 = new Relation { question = question63, answer = answer101, answerList = _answersArticle };
            var relation64 = new Relation { question = question64, answer = answer102, answerList = _answersArticle };
            var relation65 = new Relation { question = question65, answer = answer103, answerList = _answersArticle };
            var relation66 = new Relation { question = question66, answer = answer104, answerList = _answersArticle };


            var relation67 = new Relation { question = question67, answer = answer105, answerList = _answersArticle };
            var relation68 = new Relation { question = question68, answer = answer106, answerList = _answersArticle };
            var relation69 = new Relation { question = question69, answer = answer107, answerList = _answersArticle };
            var relation70 = new Relation { question = question70, answer = answer108, answerList = _answersArticle };
            var relation71 = new Relation { question = question71, answer = answer105, answerList = _answersArticle };
            var relation72 = new Relation { question = question72, answer = answer106, answerList = _answersArticle };
            var relation73 = new Relation { question = question73, answer = answer107, answerList = _answersArticle };
            var relation74 = new Relation { question = question74, answer = answer108, answerList = _answersArticle };

            var relation75 = new Relation { question = question75, answer = answer109, answerList = _answersNumbers };
            var relation76 = new Relation { question = question76, answer = answer110, answerList = _answersNumbers };
            var relation77 = new Relation { question = question77, answer = answer111, answerList = _answersNumbers };
            var relation78 = new Relation { question = question78, answer = answer112, answerList = _answersNumbers };
            var relation79 = new Relation { question = question79, answer = answer113, answerList = _answersNumbers };
            var relation80 = new Relation { question = question80, answer = answer114, answerList = _answersNumbers };
            var relation81 = new Relation { question = question81, answer = answer115, answerList = _answersNumbers };
            var relation82 = new Relation { question = question82, answer = answer116, answerList = _answersNumbers };
            var relation83 = new Relation { question = question83, answer = answer117, answerList = _answersNumbers };
            var relation84 = new Relation { question = question84, answer = answer118, answerList = _answersNumbers };
            var relation85 = new Relation { question = question85, answer = answer119, answerList = _answersNumbers };
            var relation86 = new Relation { question = question86, answer = answer120, answerList = _answersNumbers };
            var relation87 = new Relation { question = question87, answer = answer121, answerList = _answersNumbers };
            var relation88 = new Relation { question = question88, answer = answer122, answerList = _answersNumbers };
            var relation89 = new Relation { question = question89, answer = answer123, answerList = _answersNumbers };
            var relation90 = new Relation { question = question90, answer = answer124, answerList = _answersNumbers };
            var relation91 = new Relation { question = question91, answer = answer125, answerList = _answersNumbers };
            var relation92 = new Relation { question = question92, answer = answer126, answerList = _answersNumbers };
            var relation93 = new Relation { question = question93, answer = answer127, answerList = _answersNumbers };
            var relation94 = new Relation { question = question94, answer = answer128, answerList = _answersNumbers };
            var relation95 = new Relation { question = question95, answer = answer129, answerList = _answersNumbers };
            var relation96 = new Relation { question = question96, answer = answer130, answerList = _answersNumbers };
            var relation97 = new Relation { question = question97, answer = answer131, answerList = _answersNumbers };
            var relation98 = new Relation { question = question98, answer = answer132, answerList = _answersNumbers };
            var relation99 = new Relation { question = question99, answer = answer133, answerList = _answersNumbers };
            var relation100 = new Relation { question = question100, answer = answer134, answerList = _answersNumbers };
            var relation101 = new Relation { question = question101, answer = answer135, answerList = _answersNumbers };
            var relation102 = new Relation { question = question102, answer = answer136, answerList = _answersNumbers };
            var relation103 = new Relation { question = question103, answer = answer137, answerList = _answersNumbers };
            var relation104 = new Relation { question = question104, answer = answer138, answerList = _answersNumbers };
            var relation105 = new Relation { question = question105, answer = answer139, answerList = _answersNumbers };
            var relation106 = new Relation { question = question106, answer = answer140, answerList = _answersNumbers };
            var relation107 = new Relation { question = question107, answer = answer141, answerList = _answersNumbers };
            var relation108 = new Relation { question = question108, answer = answer142, answerList = _answersNumbers };
            var relation109 = new Relation { question = question109, answer = answer143, answerList = _answersNumbers };
            var relation110 = new Relation { question = question110, answer = answer144, answerList = _answersNumbers };
            var relation111 = new Relation { question = question111, answer = answer145, answerList = _answersNumbers };
            var relation112 = new Relation { question = question112, answer = answer146, answerList = _answersNumbers };
            var relation113 = new Relation { question = question113, answer = answer147, answerList = _answersNumbers };
            var relation114 = new Relation { question = question114, answer = answer148, answerList = _answersNumbers };
            var relation115 = new Relation { question = question115, answer = answer149, answerList = _answersNumbers };
            var relation116 = new Relation { question = question116, answer = answer150, answerList = _answersNumbers };
            var relation117 = new Relation { question = question117, answer = answer151, answerList = _answersNumbers };
            var relation118 = new Relation { question = question118, answer = answer152, answerList = _answersNumbers };
            var relation119 = new Relation { question = question119, answer = answer153, answerList = _answersNumbers };
            var relation120 = new Relation { question = question120, answer = answer154, answerList = _answersNumbers };
            var relation121 = new Relation { question = question121, answer = answer155, answerList = _answersNumbers };
            var relation122 = new Relation { question = question122, answer = answer156, answerList = _answersNumbers };
            var relation123 = new Relation { question = question123, answer = answer157, answerList = _answersNumbers };
            var relation124 = new Relation { question = question124, answer = answer158, answerList = _answersNumbers };
            var relation125 = new Relation { question = question125, answer = answer159, answerList = _answersNumbers };
            var relation126 = new Relation { question = question126, answer = answer160, answerList = _answersNumbers };
            var relation127 = new Relation { question = question127, answer = answer161, answerList = _answersNumbers };
            var relation128 = new Relation { question = question128, answer = answer162, answerList = _answersNumbers };
            var relation129 = new Relation { question = question129, answer = answer163, answerList = _answersNumbers };
            var relation130 = new Relation { question = question130, answer = answer164, answerList = _answersNumbers };
            var relation131 = new Relation { question = question131, answer = answer165, answerList = _answersNumbers };
            var relation132 = new Relation { question = question132, answer = answer166, answerList = _answersNumbers };
            var relation133 = new Relation { question = question133, answer = answer167, answerList = _answersNumbers };
            var relation134 = new Relation { question = question134, answer = answer168, answerList = _answersNumbers };
            var relation135 = new Relation { question = question135, answer = answer169, answerList = _answersNumbers };
            var relation136 = new Relation { question = question136, answer = answer170, answerList = _answersNumbers };
            var relation137 = new Relation { question = question137, answer = answer171, answerList = _answersNumbers };
            var relation138 = new Relation { question = question138, answer = answer172, answerList = _answersNumbers };
            var relation139 = new Relation { question = question139, answer = answer173, answerList = _answersNumbers };
            var relation140 = new Relation { question = question140, answer = answer174, answerList = _answersNumbers };
            var relation141 = new Relation { question = question141, answer = answer175, answerList = _answersNumbers };
            var relation142 = new Relation { question = question142, answer = answer176, answerList = _answersNumbers };
            var relation143 = new Relation { question = question143, answer = answer177, answerList = _answersNumbers };
            var relation144 = new Relation { question = question144, answer = answer178, answerList = _answersNumbers };

            var relation145 = new Relation { question = question145, answer = answer179, answerList = new List<Answer> { answer188, answer190, answer185 } };
            var relation146 = new Relation { question = question146, answer = answer185, answerList = new List<Answer> { answer184, answer181, answer180 } };
            var relation147 = new Relation { question = question147, answer = answer180, answerList = new List<Answer> { answer185, answer186, answer190 } };
            var relation148 = new Relation { question = question148, answer = answer186, answerList = new List<Answer> { answer179, answer183, answer184 } };
            var relation149 = new Relation { question = question149, answer = answer181, answerList = new List<Answer> { answer185, answer189, answer187 } };
            var relation150 = new Relation { question = question150, answer = answer187, answerList = new List<Answer> { answer183, answer180, answer179} };
            var relation151 = new Relation { question = question151, answer = answer182, answerList = new List<Answer> { answer185, answer190, answer187} };
            var relation152 = new Relation { question = question152, answer = answer188, answerList = new List<Answer> { answer179, answer183, answer184} };
            var relation153 = new Relation { question = question153, answer = answer183, answerList = new List<Answer> { answer190, answer188, answer186} };
            var relation154 = new Relation { question = question154, answer = answer189, answerList = new List<Answer> { answer181, answer183, answer182} };

            var relation155 = new Relation { question = question155, answer = answer204, answerList = _answersLieu };
            var relation156 = new Relation { question = question156, answer = answer191, answerList = _answersLieu };
            var relation157 = new Relation { question = question157, answer = answer192, answerList = _answersLieu };
            var relation158 = new Relation { question = question158, answer = answer194, answerList = _answersLieu };
            var relation159 = new Relation { question = question159, answer = answer195, answerList = _answersLieu };
            var relation160 = new Relation { question = question160, answer = answer193, answerList = _answersLieu };
            var relation161 = new Relation { question = question161, answer = answer199, answerList = _answersLieu };
            var relation162 = new Relation { question = question162, answer = answer200, answerList = _answersLieu };
            var relation163 = new Relation { question = question163, answer = answer201, answerList = _answersLieu };
            var relation164 = new Relation { question = question164, answer = answer196, answerList = _answersLieu };
            var relation165 = new Relation { question = question165, answer = answer197, answerList = _answersLieu };
            var relation166 = new Relation { question = question166, answer = answer198, answerList = _answersLieu };
            var relation167 = new Relation { question = question167, answer = answer203, answerList = _answersLieu };
            var relation168 = new Relation { question = question168, answer = answer202, answerList = _answersLieu };



            _answersEtrePresent.Add(answer48);
            _answersEtrePresent.Add(answer49);
            _answersEtrePresent.Add(answer50);
            _answersEtrePresent.Add(answer52);
            _answersEtrePresent.Add(answer58);
            _answersEtrePresent.Add(answer59);

            _answerJoursSemaine.Add(answer68);
            _answerJoursSemaine.Add(answer69);
            _answerJoursSemaine.Add(answer70);
            _answerJoursSemaine.Add(answer71);
            _answerJoursSemaine.Add(answer72);
            _answerJoursSemaine.Add(answer73);
            _answerJoursSemaine.Add(answer74);

            _answersMonths.Add(answer88);
            _answersMonths.Add(answer89);
            _answersMonths.Add(answer90);
            _answersMonths.Add(answer91);
            _answersMonths.Add(answer92);
            _answersMonths.Add(answer93);
            _answersMonths.Add(answer94);
            _answersMonths.Add(answer95);
            _answersMonths.Add(answer96);
            _answersMonths.Add(answer97);
            _answersMonths.Add(answer98);
            _answersMonths.Add(answer99);

            _answersArticle.Add(answer101);
            _answersArticle.Add(answer102);
            _answersArticle.Add(answer103);
            _answersArticle.Add(answer104);
            _answersArticle.Add(answer105);
            _answersArticle.Add(answer106);
            _answersArticle.Add(answer107);
            _answersArticle.Add(answer108);
            _answersNumbers.Add(answer109);
            _answersNumbers.Add(answer110);
            _answersNumbers.Add(answer111);
            _answersNumbers.Add(answer112);
            _answersNumbers.Add(answer113);
            _answersNumbers.Add(answer114);
            _answersNumbers.Add(answer115);
            _answersNumbers.Add(answer116);
            _answersNumbers.Add(answer117);
            _answersNumbers.Add(answer118);
            _answersNumbers.Add(answer119);
            _answersNumbers.Add(answer120);
            _answersNumbers.Add(answer121);
            _answersNumbers.Add(answer122);
            _answersNumbers.Add(answer123);
            _answersNumbers.Add(answer124);
            _answersNumbers.Add(answer125);
            _answersNumbers.Add(answer126);
            _answersNumbers.Add(answer127);
            _answersNumbers.Add(answer128);
            _answersNumbers.Add(answer129);
            _answersNumbers.Add(answer130);
            _answersNumbers.Add(answer131);
            _answersNumbers.Add(answer132);
            _answersNumbers.Add(answer133);
            _answersNumbers.Add(answer134);
            _answersNumbers.Add(answer135);
            _answersNumbers.Add(answer136);
            _answersNumbers.Add(answer137);
            _answersNumbers.Add(answer138);
            _answersNumbers.Add(answer139);
            _answersNumbers.Add(answer140);
            _answersNumbers.Add(answer141);
            _answersNumbers.Add(answer142);
            _answersNumbers.Add(answer143);
            _answersNumbers.Add(answer144);
            _answersNumbers.Add(answer145);
            _answersNumbers.Add(answer146);
            _answersNumbers.Add(answer147);
            _answersNumbers.Add(answer148);
            _answersNumbers.Add(answer149);
            _answersNumbers.Add(answer150);
            _answersNumbers.Add(answer151);
            _answersNumbers.Add(answer152);
            _answersNumbers.Add(answer153);
            _answersNumbers.Add(answer154);
            _answersNumbers.Add(answer155);
            _answersNumbers.Add(answer156);
            _answersNumbers.Add(answer157);
            _answersNumbers.Add(answer158);
            _answersNumbers.Add(answer159);
            _answersNumbers.Add(answer160);
            _answersNumbers.Add(answer161);
            _answersNumbers.Add(answer162);
            _answersNumbers.Add(answer163);
            _answersNumbers.Add(answer164);
            _answersNumbers.Add(answer165);
            _answersNumbers.Add(answer166);
            _answersNumbers.Add(answer167);
            _answersNumbers.Add(answer168);
            _answersNumbers.Add(answer169);
            _answersNumbers.Add(answer170);
            _answersNumbers.Add(answer171);
            _answersNumbers.Add(answer172);
            _answersNumbers.Add(answer173);
            _answersNumbers.Add(answer174);
            _answersNumbers.Add(answer175);
            _answersNumbers.Add(answer176);
            _answersNumbers.Add(answer177);
            _answersNumbers.Add(answer178);

            _answersLieu.Add(answer191);
            _answersLieu.Add(answer192);
            _answersLieu.Add(answer193);
            _answersLieu.Add(answer194);
            _answersLieu.Add(answer195);
            _answersLieu.Add(answer196);
            _answersLieu.Add(answer197);
            _answersLieu.Add(answer198);
            _answersLieu.Add(answer199);
            _answersLieu.Add(answer200);
            _answersLieu.Add(answer201);
            _answersLieu.Add(answer202);
            _answersLieu.Add(answer203);
            _answersLieu.Add(answer204);

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

            _questionsWeek.Add(question36);
            _questionsWeek.Add(question37);
            _questionsWeek.Add(question38);
            _questionsWeek.Add(question39);
            _questionsWeek.Add(question40);
            _questionsWeek.Add(question41);
            _questionsWeek.Add(question42);
            _questionsWeek.Add(question44);
            _questionsWeek.Add(question45);
            _questionsWeek.Add(question46);

            _questionMonth.Add(question47);
            _questionMonth.Add(question48);
            _questionMonth.Add(question49);
            _questionMonth.Add(question50);
            _questionMonth.Add(question51);
            _questionMonth.Add(question52);
            _questionMonth.Add(question53);
            _questionMonth.Add(question54);
            _questionMonth.Add(question55);
            _questionMonth.Add(question56);
            _questionMonth.Add(question57);
            _questionMonth.Add(question58);

            _questionArticle.Add(question59);
            _questionArticle.Add(question60);
            _questionArticle.Add(question61);
            _questionArticle.Add(question62);
            _questionArticle.Add(question63);
            _questionArticle.Add(question64);
            _questionArticle.Add(question65);
            _questionArticle.Add(question66);
            _questionArticle.Add(question67);
            _questionArticle.Add(question68);
            _questionArticle.Add(question69);
            _questionArticle.Add(question70);
            _questionArticle.Add(question71);
            _questionArticle.Add(question72);
            _questionArticle.Add(question73);
            _questionArticle.Add(question74);

            _questionNumbers.Add(question75);
            _questionNumbers.Add(question76);
            _questionNumbers.Add(question77);
            _questionNumbers.Add(question78);
            _questionNumbers.Add(question79);
            _questionNumbers.Add(question80);
            _questionNumbers.Add(question81);
            _questionNumbers.Add(question82);
            _questionNumbers.Add(question83);
            _questionNumbers.Add(question84);
            _questionNumbers.Add(question85);
            _questionNumbers.Add(question86);
            _questionNumbers.Add(question87);
            _questionNumbers.Add(question88);
            _questionNumbers.Add(question89);
            _questionNumbers.Add(question90);
            _questionNumbers.Add(question91);
            _questionNumbers.Add(question92);
            _questionNumbers.Add(question93);
            _questionNumbers.Add(question94);
            _questionNumbers.Add(question95);
            _questionNumbers.Add(question96);
            _questionNumbers.Add(question97);
            _questionNumbers.Add(question98);
            _questionNumbers.Add(question99);
            _questionNumbers.Add(question100);
            _questionNumbers.Add(question101);
            _questionNumbers.Add(question102);
            _questionNumbers.Add(question103);
            _questionNumbers.Add(question104);
            _questionNumbers.Add(question105);
            _questionNumbers.Add(question106);
            _questionNumbers.Add(question107);
            _questionNumbers.Add(question108);
            _questionNumbers.Add(question109);
            _questionNumbers.Add(question110);
            _questionNumbers.Add(question111);
            _questionNumbers.Add(question112);
            _questionNumbers.Add(question113);
            _questionNumbers.Add(question114);
            _questionNumbers.Add(question115);
            _questionNumbers.Add(question116);
            _questionNumbers.Add(question117);
            _questionNumbers.Add(question118);
            _questionNumbers.Add(question119);
            _questionNumbers.Add(question120);
            _questionNumbers.Add(question121);
            _questionNumbers.Add(question122);
            _questionNumbers.Add(question123);
            _questionNumbers.Add(question124);
            _questionNumbers.Add(question125);
            _questionNumbers.Add(question126);
            _questionNumbers.Add(question127);
            _questionNumbers.Add(question128);
            _questionNumbers.Add(question129);
            _questionNumbers.Add(question130);
            _questionNumbers.Add(question131);
            _questionNumbers.Add(question132);
            _questionNumbers.Add(question133);
            _questionNumbers.Add(question134);
            _questionNumbers.Add(question135);
            _questionNumbers.Add(question136);
            _questionNumbers.Add(question137);
            _questionNumbers.Add(question138);
            _questionNumbers.Add(question139);
            _questionNumbers.Add(question140);
            _questionNumbers.Add(question141);
            _questionNumbers.Add(question142);
            _questionNumbers.Add(question143);
            _questionNumbers.Add(question144);

            _questionAdjetive.Add(question145);
            _questionAdjetive.Add(question146);
            _questionAdjetive.Add(question147);
            _questionAdjetive.Add(question148);
            _questionAdjetive.Add(question149);
            _questionAdjetive.Add(question150);
            _questionAdjetive.Add(question151);
            _questionAdjetive.Add(question152);
            _questionAdjetive.Add(question153);
            _questionAdjetive.Add(question154);

            _questionLieu.Add(question155);
            _questionLieu.Add(question156);
            _questionLieu.Add(question157);
            _questionLieu.Add(question158);
            _questionLieu.Add(question159);
            _questionLieu.Add(question160);
            _questionLieu.Add(question161);
            _questionLieu.Add(question162);
            _questionLieu.Add(question163);
            _questionLieu.Add(question164);
            _questionLieu.Add(question165);
            _questionLieu.Add(question166);
            _questionLieu.Add(question167);
            _questionLieu.Add(question168);


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
            _relations.Add(relation36);
            _relations.Add(relation37);
            _relations.Add(relation38);
            _relations.Add(relation39);
            _relations.Add(relation40);
            _relations.Add(relation41);
            _relations.Add(relation42);
            _relations.Add(relation43);
            _relations.Add(relation44);
            _relations.Add(relation45);
            _relations.Add(relation46);
            _relations.Add(relation47);
            _relations.Add(relation48);
            _relations.Add(relation49);
            _relations.Add(relation50);
            _relations.Add(relation51);
            _relations.Add(relation52);
            _relations.Add(relation53);
            _relations.Add(relation54);
            _relations.Add(relation55);
            _relations.Add(relation56);
            _relations.Add(relation57);
            _relations.Add(relation59);
            _relations.Add(relation60);
            _relations.Add(relation61);
            _relations.Add(relation62);
            _relations.Add(relation63);
            _relations.Add(relation64);
            _relations.Add(relation65);
            _relations.Add(relation66);
            _relations.Add(relation67);
            _relations.Add(relation68);
            _relations.Add(relation69);
            _relations.Add(relation70);
            _relations.Add(relation71);
            _relations.Add(relation72);
            _relations.Add(relation73);
            _relations.Add(relation74);
            _relations.Add(relation75);
            _relations.Add(relation76);
            _relations.Add(relation77);
            _relations.Add(relation78);
            _relations.Add(relation79);
            _relations.Add(relation80);
            _relations.Add(relation81);
            _relations.Add(relation82);
            _relations.Add(relation83);
            _relations.Add(relation84);
            _relations.Add(relation85);
            _relations.Add(relation86);
            _relations.Add(relation87);
            _relations.Add(relation88);
            _relations.Add(relation89);
            _relations.Add(relation90);
            _relations.Add(relation91);
            _relations.Add(relation92);
            _relations.Add(relation93);
            _relations.Add(relation94);
            _relations.Add(relation95);
            _relations.Add(relation96);
            _relations.Add(relation97);
            _relations.Add(relation98);
            _relations.Add(relation99);
            _relations.Add(relation100);
            _relations.Add(relation101);
            _relations.Add(relation102);
            _relations.Add(relation103);
            _relations.Add(relation104);
            _relations.Add(relation105);
            _relations.Add(relation106);
            _relations.Add(relation107);
            _relations.Add(relation108);
            _relations.Add(relation109);
            _relations.Add(relation110);
            _relations.Add(relation111);
            _relations.Add(relation112);
            _relations.Add(relation113);
            _relations.Add(relation114);
            _relations.Add(relation115);
            _relations.Add(relation116);
            _relations.Add(relation117);
            _relations.Add(relation118);
            _relations.Add(relation119);
            _relations.Add(relation120);
            _relations.Add(relation121);
            _relations.Add(relation122);
            _relations.Add(relation123);
            _relations.Add(relation124);
            _relations.Add(relation125);
            _relations.Add(relation126);
            _relations.Add(relation127);
            _relations.Add(relation128);
            _relations.Add(relation129);
            _relations.Add(relation130);
            _relations.Add(relation131);
            _relations.Add(relation132);
            _relations.Add(relation133);
            _relations.Add(relation134);
            _relations.Add(relation135);
            _relations.Add(relation136);
            _relations.Add(relation137);
            _relations.Add(relation138);
            _relations.Add(relation139);
            _relations.Add(relation140);
            _relations.Add(relation141);
            _relations.Add(relation142);
            _relations.Add(relation143);
            _relations.Add(relation144);
            _relations.Add(relation145);
            _relations.Add(relation146);
            _relations.Add(relation147);
            _relations.Add(relation148);
            _relations.Add(relation149);
            _relations.Add(relation150);
            _relations.Add(relation151);
            _relations.Add(relation152);
            _relations.Add(relation153);
            _relations.Add(relation154);
            _relations.Add(relation155);
            _relations.Add(relation156);
            _relations.Add(relation157);
            _relations.Add(relation158);
            _relations.Add(relation159);
            _relations.Add(relation160);
            _relations.Add(relation161);
            _relations.Add(relation162);
            _relations.Add(relation163);
            _relations.Add(relation164);
            _relations.Add(relation165);
            _relations.Add(relation166);
            _relations.Add(relation167);
            _relations.Add(relation168);

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

        public List<Question> getQuestionsWeek(int quantity)
        {
            List<Question> selectedQuestions = new List<Question>();
            HashSet<Question> selectedQuestionSet = new HashSet<Question>();

            quantity = Math.Min(quantity, _questionsWeek.Count);

            List<Question> shuffledQuestions = _questionsWeek.OrderBy(q => Guid.NewGuid()).ToList();

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

        public List<Relation> getAnswersWeek(List<Question> questions)
        {
            List<Relation> result = new List<Relation>();

            foreach (var question in questions)
            {
                if (question.Id >= 36 && question.Id <= 45)
                {
                    var questionDTO = _questionsWeek.FirstOrDefault(q => q.ToString() == question.ToString());

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

        public List<Question> getQuestionsMonth(int quantity)
        {
            List<Question> selectedQuestions = new List<Question>();
            HashSet<Question> selectedQuestionSet = new HashSet<Question>();

            quantity = Math.Min(quantity, _questionMonth.Count);

            List<Question> shuffledQuestions = _questionMonth.OrderBy(q => Guid.NewGuid()).ToList();

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

        public List<Relation> getAnswersMonth(List<Question> questions)
        {
            List<Relation> result = new List<Relation>();

            foreach (var question in questions)
            {
                if (question.Id >= 46 && question.Id <= 57)
                {
                    var questionDTO = _questionMonth.FirstOrDefault(q => q.ToString() == question.ToString());

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

        public List<Question> getQuestionsArticle(int quantity)
        {
            List<Question> selectedQuestions = new List<Question>();
            HashSet<Question> selectedQuestionSet = new HashSet<Question>();

            quantity = Math.Min(quantity, _questionArticle.Count);

            List<Question> shuffledQuestions = _questionArticle.OrderBy(q => Guid.NewGuid()).ToList();

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

        public List<Relation> getAnswersArticle(List<Question> questions)
        {
            List<Relation> result = new List<Relation>();

            foreach (var question in questions)
            {
                if (question.Id >= 59 && question.Id <= 74)
                {
                    var questionDTO = _questionArticle.FirstOrDefault(q => q.ToString() == question.ToString());

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

        public List<Question> getQuestionsNumber(int quantity)
        {
            List<Question> selectedQuestions = new List<Question>();
            HashSet<Question> selectedQuestionSet = new HashSet<Question>();

            quantity = Math.Min(quantity, _questionNumbers.Count);

            List<Question> shuffledQuestions = _questionNumbers.OrderBy(q => Guid.NewGuid()).ToList();

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

        public List<Relation> getAnswersNumber(List<Question> questions)
        {
            List<Relation> result = new List<Relation>();

            foreach (var question in questions)
            {
                if (question.Id >= 75 && question.Id <= 144)
                {
                    var questionDTO = _questionNumbers.FirstOrDefault(q => q.ToString() == question.ToString());

                    if (questionDTO != null)
                    {
                        var relationDTO = _relations.FirstOrDefault(r => r.question?.Id == questionDTO.Id);

                        if (relationDTO != null)
                        {
                            var distinctAnswers = relationDTO.answerList
                                .Where(a => a != relationDTO.answer)
                                .Distinct()
                                .OrderBy(a => Guid.NewGuid()) // Shuffle the distinct answers
                                .Take(3)
                                .ToList();

                            relationDTO.answerList = distinctAnswers;

                            result.Add(relationDTO);
                        }
                    }
                }
            }

            return result;
        }

        public List<Question> getQuestionsAdjetive(int quantity)
        {
            List<Question> selectedQuestions = new List<Question>();
            HashSet<Question> selectedQuestionSet = new HashSet<Question>();

            quantity = Math.Min(quantity, _questionAdjetive.Count);

            List<Question> shuffledQuestions = _questionAdjetive.OrderBy(q => Guid.NewGuid()).ToList();

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

        public List<Relation> getAnswersAdjetive(List<Question> questions)
        {
            List<Relation> result = new List<Relation>();

            foreach (var question in questions)
            {
                if (question.Id >= 145 && question.Id <= 154)
                {
                    var questionDTO = _questionAdjetive.FirstOrDefault(q => q.ToString() == question.ToString());

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

        public List<Question> getQuestionsLieu(int quantity)
        {
            List<Question> selectedQuestions = new List<Question>();
            HashSet<Question> selectedQuestionSet = new HashSet<Question>();

            quantity = Math.Min(quantity, _questionLieu.Count);

            List<Question> shuffledQuestions = _questionLieu.OrderBy(q => Guid.NewGuid()).ToList();

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

        public List<Relation> getAnswersLieu(List<Question> questions)
        {
            List<Relation> result = new List<Relation>();

            foreach (var question in questions)
            {
                if (question.Id >= 155 && question.Id <= 168)
                {
                    var questionDTO = _questionLieu.FirstOrDefault(q => q.ToString() == question.ToString());

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
