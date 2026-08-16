using CashFlow.Communication.Reponses;
using CashFlow.Communication.Requests;

namespace CashFlow.Application.UseCases.Expenses.Register;

public interface IRegisterExpenseUseCase
{
    ResponseRegisteredExpense Execute(RequestRegisterExpense request);
}
