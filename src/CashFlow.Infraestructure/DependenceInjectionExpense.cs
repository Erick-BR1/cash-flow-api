using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Infraestructure.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.Infraestructure;

public static class DependenceInjectionExtension
{
    public static void AddInfraestructure(this IServiceCollection services)
    {
        services.AddScoped<IExpensesRepository, ExpensesRepository>();
    }
}
