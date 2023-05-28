using Microsoft.AspNetCore.Mvc;
using ExerciseBPO.Interfaces;
using ExerciseBPO.Models;

namespace ExerciseBPO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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

        [HttpGet("addition")]
        public ActionResult<Result> Addition([FromQuery] float firstSummand, float secondSummand)
        {
            return _simpleMathematicalExpressions.Addition(firstSummand, secondSummand);
        }

        [HttpGet("subtraction")]
        public ActionResult<Result> Subtraction([FromQuery] float subtrahend, float subtractor)
        {
            return _simpleMathematicalExpressions.Subtraction(subtrahend, subtractor);
        }

        [HttpGet("multiplication")]
        public ActionResult<Result> Multiplication([FromQuery] float firstMultiplier, float secondMultiplier)
        {
            return _simpleMathematicalExpressions.Multiplication(firstMultiplier, secondMultiplier);
        }

        [HttpGet("division")]
        public ActionResult<Result> Division([FromQuery] float dividend, float divider)
        {
            return _simpleMathematicalExpressions.Division(dividend, divider);
        }

        [HttpGet("exponentiation")]
        public ActionResult<Result> Exponentiation([FromQuery] float baseOfDegree, float exponent)
        {
            return _simpleMathematicalExpressions.Exponentiation(baseOfDegree, exponent);
        }

        [HttpGet("api/calc/rooting-by-base")]
        public ActionResult<Result> RootingByBase([FromQuery] float radicalExpression, float rootDegree)
        {
            return _simpleMathematicalExpressions.RootingByBase(radicalExpression, rootDegree);
        }

        [HttpGet("complex-expression")]
        public ActionResult<Result> ComplexExpression([FromQuery] string expression)
        {
            return _complexMathematicalExpression.ComplexExpression(expression);
        }
    }
}
