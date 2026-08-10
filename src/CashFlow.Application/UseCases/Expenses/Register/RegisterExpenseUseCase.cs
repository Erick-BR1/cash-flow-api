using CashFlow.Communication.Reponses;
using CashFlow.Communication.Requests;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseUseCase
{
    public ResponseRegisteredExpense Execute (RequestRegisterExpense request)
    {
        Validate(request);
        return new ResponseRegisteredExpense();
    }

    private void Validate(RequestRegisterExpense request)
    {
        var validator = new RegisterExpenseValidator();
        
        var result = validator.Validate(request);

        if(result.IsValid == false)
        {
            var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();
            throw new ArgumentException();
        }
    }
}
