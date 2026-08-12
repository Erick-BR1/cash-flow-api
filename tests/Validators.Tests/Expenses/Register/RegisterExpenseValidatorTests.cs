using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;

namespace Validators.Tests.Expenses.Register;

public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
        //Arrange
        var validator = new RegisterExpenseValidator();
        var request = new RequestRegisterExpense
        {
            Title = "Test",
            Description = "Test Expense",
            Amount = 100,
            PaymentType = CashFlow.Communication.Enums.PaymentType.CreditCard,
            Date = DateTime.Now.AddDays(-1)
        };

        //Act
        var result = validator.Validate(request);

        //Assert
        Assert.True(result.IsValid);

    }
}
