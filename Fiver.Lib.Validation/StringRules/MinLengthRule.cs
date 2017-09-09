namespace Fiver.Lib.Validation.StringRules
{
    public class MinLengtRule : IRule
    {
        private readonly string field;
        private readonly string value;
        private readonly int length;
        private readonly string message;

        public MinLengtRule(string field, string value, int length, string message)
        {
            this.field = field;
            this.value = value;
            this.length = length;
            this.message = message;
        }

        public string Field => this.field;
        public string Message => this.message;
        public bool IsValid() => this.value.Length > this.length;
    }
}
