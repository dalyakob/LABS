namespace Lab_11
{
    public class Movie
    {
        public Movie(string title, Categories category)
        {
            Title = title;
            Category = category;
        }
        public string Title { get; set; }
        public Categories Category { get; set; }
    }
}