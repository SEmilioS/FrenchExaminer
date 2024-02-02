namespace FEWebApp.Models
{
    public class Relation
    {
        public Question question { get; set; }
        public Answer answer { get; set; }
        public List<Answer> answerList { get; set;}
        public Answer selectedItem { get; set; }
        public int grade { get; set; }
        public Image img { get; set; }
    }
}
