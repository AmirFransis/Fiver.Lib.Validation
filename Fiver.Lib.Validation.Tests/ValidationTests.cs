using Fiver.Lib.Validation.Tests.Model;
using Xunit;

namespace Fiver.Lib.Validation.Tests
{
    public class ValidationTests
    {
        [Fact(DisplayName = "Using_validation_issues")]
        public void Using_validation_issues()
        {
            var value = "Tahir";

            var issues = new ValidationIssues()
                            .AddIf("Title", value.Length == 0, "Title is required")
                            .AddIf("Title", value.StartsWith("S"), "Title should start with T")
                            .AddIf("Title", () => value.Length > 3, "Title must be more than 3 characters");
            
            Assert.True(issues.HasIssues);
        }

        [Fact(DisplayName = "Using_custom_validator")]
        public void Using_custom_validator()
        {
            var model = new Movie
            {
                Id = 1,
                Title = "Dr. No",
                ReleaseYear = 1963
            };

            var validator = new MovieValidator(model);
            var issues = validator.Validate();

            Assert.False(issues.HasIssues);
        }
    }
}
