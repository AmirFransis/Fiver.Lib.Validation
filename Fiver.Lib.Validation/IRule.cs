namespace Fiver.Lib.Validation
{
    public interface IRule
    {
        string Field { get; }
        string Message { get; }
        bool IsValid();
    }
}
