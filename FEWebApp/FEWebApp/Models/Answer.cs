namespace FEWebApp.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public String value {  get; set; }

        public override string ToString()
        {
            return this.value;
        }
    }

   
}
