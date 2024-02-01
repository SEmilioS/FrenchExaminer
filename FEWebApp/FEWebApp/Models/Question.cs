namespace FEWebApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string value { get; set; }

        public override string ToString()
        {
            return this.value;
        }
    }
}
