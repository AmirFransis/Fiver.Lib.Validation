namespace Fiver.Lib.Validation
{
    public sealed class ValidationIssue
    {
        public ValidationIssue(string field, string message)
        {
            Field = field;
            Message = message;
        }

        public string Field { get; }
        public string Message { get; }
    }
}
