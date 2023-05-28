using ExerciseBPO.Interfaces;
using AngouriMath.Extensions;
using ExerciseBPO.Models;

namespace ExerciseBPO.Services
{
    public class ComplexMathematicalExpressionServices : IComplexMathematicalExpressionServices
    {
        public Result ComplexExpression(string expression)
        {
            float result;
            try
            {
                result = (float)expression.EvalNumerical();
            }
            catch
            {
                return new Result()
                {
                    StatusCode = Status.InvalidInputString,
                    MessageException = "Строка имеет не поддерживаемые выражения"
                };
            }

            return new Result(result);
        }
    }
}