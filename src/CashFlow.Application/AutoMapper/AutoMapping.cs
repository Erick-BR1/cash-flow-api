using AutoMapper;
using CashFlow.Communication.Reponses;
using CashFlow.Communication.Requests;
using CashFlow.Domain.Entities;

namespace CashFlow.Application.Mappings;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        RequestToEntity();
        EntityToResponse();
    }

    private void RequestToEntity()
    {
        CreateMap<RequestRegisterExpense, Expense>();
    }

    private void EntityToResponse()
    {
        CreateMap<Expense, ResponseRegisteredExpense>();
        CreateMap<Expense, ResponseShortExpense>();
    }
}