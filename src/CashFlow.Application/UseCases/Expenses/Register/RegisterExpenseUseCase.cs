using CashFlow.Communication.Reponses;
using CashFlow.Communication.Requests;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseUseCase
{
    public ResponseRegisteredExpense Execute (RequestRegisterExpense request)
    {
        return new ResponseRegisteredExpense();
    }
}
