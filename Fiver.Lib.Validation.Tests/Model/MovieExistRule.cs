namespace Fiver.Lib.Validation.Tests.Model
{
    public class MovieExistRule : IRule
    {
        private readonly Movie movie;

        public MovieExistRule(Movie movie)
        {
            this.movie = movie;
        }
        
        public string Field => "Title";
        public string Message => "Title already exist";

        public bool IsValid()
        {
            if (movie.Title == "Goldfinger")
                return false;

            return true;
        }
    }
}
