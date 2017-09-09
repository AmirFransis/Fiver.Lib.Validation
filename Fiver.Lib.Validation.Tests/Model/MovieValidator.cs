using Fiver.Lib.Validation.StringRules;

namespace Fiver.Lib.Validation.Tests.Model
{
    public class MovieValidator : IValidator
    {
        private readonly Movie movie;
        
        public MovieValidator(Movie movie)
        {
            this.movie = movie;
        }

        public ValidationIssues Validate()
        {
            var issues = new ValidationIssues()
                            //.AddIf("Title", movie.Title.Length == 0, "Title is required")
                            //.AddRule(new NotEmptyRule("Title", movie.Title, "Title is required"))
                            //.AddIf("Title", () => movie.Title.Length > 20, "Title must be more than 20 characters")
                            .AddRule(new MaxLengtRule("Title", movie.Title, 20, "Title must be more than 20 characters"))
                            .AddRule(new MovieExistRule(movie));

            return issues;
        }
    }
}
