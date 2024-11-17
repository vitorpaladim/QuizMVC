namespace QuizzMVC.Models
{
    public abstract class AbstractQuestion
    {
        public string Text { get; set; }
        public abstract string GetAnswer();
    }
}
