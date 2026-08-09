using CashFlow.Communication.Reponses;
using CashFlow.Communication.Requests;

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
        var titleIsEmpty = string.IsNullOrWhiteSpace(request.Title);
        if (titleIsEmpty) throw new ArgumentException("Title is required.");

        if (request.Amount <= 0) throw new ArgumentException("Amount must be greater than zero");

        var result = DateTime.Compare(request.Date, DateTime.UtcNow);
        if (result > 0) throw new ArgumentException("Expenses cannot be for the future.");

        var paymentTypeIsValid = Enum.IsDefined(typeof(ResponseRegisteredExpense), request.PaymentType);
        if (paymentTypeIsValid == false) throw new ArgumentException("Payment type invalid.");
    }
}
