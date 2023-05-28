using ExerciseBPO.Interfaces;
using ExerciseBPO.Models;

namespace ExerciseBPO.Services
{
    public class SimpleMathematicalExpressionsServices : ISimpleMathematicalExpressionsServices
    {
        public Result Addition(float firstSummand, float secondSummand)
        {
            return CheckInfinity(firstSummand + secondSummand);
        }

        public Result Subtraction(float subtrahend, float subtractor)
        {
            return CheckInfinity(subtrahend - subtractor);
        }

        public Result Multiplication(float firstMultiplier, float secondMultiplier)
        {
            return CheckInfinity(firstMultiplier * secondMultiplier);
        }

        public Result Division(float dividend, float divisor)
        {
            if (divisor == 0)
            {
                return new Result()
                {
                    StatusCode = Status.DivideByZeroException,
                    MessageException = "Деление на ноль - невозможно"
                };
            }

            return new Result()
            {
                CalculationResult = dividend / divisor
            };
        }

        public Result Exponentiation(float baseOfDegree, float exponent)
        {
            return CheckInfinity((float)Math.Pow(baseOfDegree, exponent));
        }

        public Result RootingByBase(float RadicalExpression, float rootDegree)
        {
            return CheckInfinity((float)Math.Pow(RadicalExpression, 1 / rootDegree));
        }

        private Result CheckInfinity(float result)
        {
            if (result == float.PositiveInfinity || result == float.NegativeInfinity)
            {
                return new Result()
                {
                    StatusCode = Status.OverflowException,
                    MessageException = "Результат вычислений - бесконечность для значения float"
                };
            }

            return new Result()
            {
                CalculationResult = result
            };
        }
    }
}