using ExerciseBPO.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseBPO.Interfaces
{
    public interface ISimpleMathematicalExpressionsServices
    {
        public Result Addition(float firstSummand, float secondSummand);
        public Result Subtraction(float subtrahend, float subtractor);
        public Result Multiplication(float firstMultiplier, float secondMultiplier);
        public Result Division(float dividend, float divisor);
        public Result Exponentiation(float baseOfDegree, float exponent);
        public Result RootingByBase(float RadicalExpression, float rootDegree);
    }
}
