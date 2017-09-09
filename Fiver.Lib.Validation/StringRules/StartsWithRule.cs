namespace Fiver.Lib.Validation.StringRules
{
    public class StartsWithRule : IRule
    {
        private readonly string field;
        private readonly string value;
        private readonly string startsWith;
        private readonly string message;

        public StartsWithRule(string field, string value, string startsWith, string message)
        {
            this.field = field;
            this.value = value;
            this.startsWith = startsWith;
            this.message = message;
        }

        public string Field => this.field;
        public string Message => this.message;
        public bool IsValid() => this.value.StartsWith(this.startsWith);
    }
}
