using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Reponses;
using CashFlow.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.API.Controllers;

[Route("api/expenses")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredExpense), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseError), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Register(
        [FromServices] IRegisterExpenseUseCase useCase,
        [FromBody] RequestRegisterExpense request)
    {
        var response = await useCase.Execute(request);

        return Created(string.Empty, response);
    }
}
