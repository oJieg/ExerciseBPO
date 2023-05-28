using ExerciseBPO.Interfaces;
using ExerciseBPO.Models;

namespace ExerciseBPO.Services
{
    public class SimpleMathematicalExpressionsServices : ISimpleMathematicalExpressionsServices
    {
        public Result Addition(float firstSummand, float secondSummand)
        {
            return new Result(firstSummand + secondSummand);
        }

        public Result Subtraction(float subtrahend, float subtractor)
        {
            return new Result(subtrahend - subtractor);
        }

        public Result Multiplication(float firstMultiplier, float secondMultiplier)
        {
            return new Result(firstMultiplier * secondMultiplier);
        }

        public Result Division(float dividend, float divider)
        {
            if (divider == 0)
            {
                return new Result()
                {
                    StatusCode = Status.OverflowException,
                    MessageException = "Деление на ноль невозможно"
                };
            }
            return new Result(dividend / divider);
        }

        public Result Exponentiation(float baseOfDegree, float exponent)
        {
            return new Result((float)Math.Pow(baseOfDegree, exponent));
        }

        public Result RootingByBase(float radicalExpression, float rootDegree)
        {
            return new Result((float)Math.Pow(radicalExpression, 1 / rootDegree));
        }

        //private static Result CheckInfinity(float result)
        //{
        //    if (float.IsInfinity(result))
        //    {
        //        return new Result()
        //        {
        //            StatusCode = Status.OverflowException,
        //            MessageException = "Результат вычислений - бесконечность для значения float"
        //        };
        //    }

        //    return new Result()
        //    {
        //        CalculationResult = result
        //    };
        //}
    }
}