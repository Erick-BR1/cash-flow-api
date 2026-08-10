using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Reponses;
using CashFlow.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpense request)
    {
        try
        {
            var useCase = new RegisterExpenseUseCase();
            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }
        catch (ArgumentException ex)
        {
            var errorResponse = new ResponseError
            {
                ErrorMessage = ex.Message
            };

            return BadRequest(errorResponse);
        }
        catch
        {
            var errorResponse = new ResponseError
            {
                ErrorMessage = "unknown error"
            };

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
}
