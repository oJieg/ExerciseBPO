using ExerciseBPO.Interfaces;
using AngouriMath.Extensions;
using ExerciseBPO.Models;

namespace ExerciseBPO.Services
{
    public class ComplexMathematicalExpressionServices : IComplexMathematicalExpressionServices
    {
        public Result ComplexExpression(string expression)
        {
            float result = (float)expression.EvalNumerical();
            if (result == float.PositiveInfinity || result == float.NegativeInfinity)
            {
                return new Result()
                {
                    StatusCode = Status.OverflowException,
                    MessageException = "Результат вычислений - бесконечность для значения float"
                };
            }
            if (float.IsNaN(result))
            {
                return new Result()
                {
                    StatusCode = Status.DivideByZeroException,
                    MessageException = "Деление на ноль - невозможно"
                };
            }

            return new Result()
            {
                CalculationResult = result
            };
        }
    }
}
