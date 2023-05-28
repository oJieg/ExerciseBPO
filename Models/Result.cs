namespace ExerciseBPO.Models
{
    public class Result
    {
        public Status StatusCode { get; set; } = Status.Success;
        public string MessageException { get; set; } = string.Empty;
        public float? CalculationResult { get; set; }
    }

    public enum Status
    {
        Success,
        OverflowException,
        DivideByZeroException,
        InvalidInputString
    }
}
