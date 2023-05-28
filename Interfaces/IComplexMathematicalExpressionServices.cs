using ExerciseBPO.Models;

namespace ExerciseBPO.Interfaces
{
    public interface IComplexMathematicalExpressionServices
    {
        public Result ComplexExpression(string expression);
    }
}
