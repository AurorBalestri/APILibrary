namespace LibraryAPI.Models
{
    public class Book
    {
        static int autoIncrementedId = 1;
        public enum GenreEnum
        {
            HORROR,
            BIOGRAPHY,
            FANTASY,
            ESSAY,
            POETRY,
            SCIFI,
            CLASSICS,
            COMIC,
            MYSTERY,
            HISTORICAL_FICTION,
            ROMANCE,
            THRILLER,
            HISTORY,
            MEMOIR
        }

        private string _author;
        private string _title;
        private int _id;
        private GenreEnum _genre;
        private bool _isAvailable;

        public string Author { get { return _author; } set { _author = value; } }
        public string Title { get { return _title; } set { _title = value; } }

        public int Id { get { return _id; } set { _id = autoIncrementedId++; } }
        public GenreEnum Genre { get; set; }
        public bool IsAvailable { get; set; }


        public Book()
        {

        }
        public Book(string autore, string title, int id, GenreEnum genre, bool isAvailable)
        {
            Author = autore;
            Title = title;
            Id = id;
            Genre = genre;
            IsAvailable = isAvailable;
        }
    }
}
