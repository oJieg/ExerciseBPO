namespace ExerciseBPO.Models
{
    public class Result
    {
        public Status StatusCode { get; set; } = Status.Success;
        public string MessageException { get; set; } = string.Empty;
        public float? CalculationResult { get; set; }

        public Result(float result)
        {
            if (float.IsInfinity(result))
            {
                StatusCode = Status.OverflowException;
                MessageException = "Результат вычислений - бесконечность для значения float";
            }
            else if (float.IsNaN(result))
            {
                StatusCode = Status.OverflowException;
                MessageException = "Деление на ноль невозможно";
            }
            else
            {
                CalculationResult = result;
            }
        }
        public Result() { }
    }

    public enum Status
    {
        Success,
        OverflowException,
        DivideByZeroException,
        InvalidInputString
    }
}