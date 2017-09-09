namespace Fiver.Lib.Validation.StringRules
{
    public class NotEmptyRule : IRule
    {
        private readonly string field;
        private readonly string value;
        private readonly string message;

        public NotEmptyRule(string field, string value, string message)
        {
            this.field = field;
            this.value = value;
            this.message = message;
        }

        public string Field => this.field;
        public string Message => this.message;
        public bool IsValid() => !string.IsNullOrEmpty(this.value);
    }
}
