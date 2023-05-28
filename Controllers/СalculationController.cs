using Microsoft.AspNetCore.Mvc;
using ExerciseBPO.Interfaces;
using ExerciseBPO.Models;

namespace ExerciseBPO.Controllers
{
    [ApiController]
    public class СalculationController : ControllerBase
    {
        private readonly ISimpleMathematicalExpressionsServices _simpleMathematicalExpressions;
        private readonly IComplexMathematicalExpressionServices _complexMathematicalExpression;

        public СalculationController(
            ISimpleMathematicalExpressionsServices simpleMathematicalExpressions,
            IComplexMathematicalExpressionServices complexMathematicalExpression)
        {
            _simpleMathematicalExpressions = simpleMathematicalExpressions;
            _complexMathematicalExpression = complexMathematicalExpression;
        }

        [HttpGet("api/calc/addition")]
        public ActionResult<Result> Addition([FromQuery] float firstSummand, float secondSummand)
        {
            return _simpleMathematicalExpressions.Addition(firstSummand, secondSummand);
        }

        [HttpGet("api/calc/subtraction")]
        public ActionResult<Result> Subtraction([FromQuery] float subtrahend, float subtractor)
        {
            return _simpleMathematicalExpressions.Subtraction(subtrahend, subtractor);
        }

        [HttpGet("api/calc/multiplication")]
        public ActionResult<Result> Multiplication([FromQuery] float firstMultiplier, float secondMultiplier)
        {
            return _simpleMathematicalExpressions.Multiplication(firstMultiplier, secondMultiplier);

        }

        [HttpGet("api/calc/division")]
        public ActionResult<Result> Division([FromQuery] float dividend, float divisor)
        {
            return _simpleMathematicalExpressions.Division(dividend, divisor);
        }

        [HttpGet("api/calc/exponentiation")]
        public ActionResult<Result> Exponentiation([FromQuery] float baseOfDegree, float exponent)
        {
            return _simpleMathematicalExpressions.Exponentiation(baseOfDegree, exponent);
        }

        [HttpGet("api/calc/rooting-by-base")]
        public ActionResult<Result> RootingByBase([FromQuery] float radicalExpression, float rootDegree)
        {
            return _simpleMathematicalExpressions.RootingByBase(radicalExpression, rootDegree);
        }

        [HttpGet("api/calc/complex-expression")]
        public ActionResult<Result> ComplexExpression([FromQuery] string expression)
        {
            try
            {
                return _complexMathematicalExpression.ComplexExpression(expression);
            }
            catch
            {
                return new Result()
                {
                    StatusCode = Status.InvalidInputString,
                    MessageException = "Cтрока имеет не поддерживаемые выражения"
                };
            }

        }

    }
}
