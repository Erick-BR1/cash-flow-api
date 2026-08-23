using CashFlow.Communication.Reponses;

namespace CashFlow.Application.UseCases.Expenses.GetAll;
public interface IGetAllExpensesUseCase
{
    Task<ResponseExpenses> Execute();
}