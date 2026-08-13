using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Exception;
using CommonTestUtilities.Requests;
using Shouldly;

namespace Validators.Tests.Expenses.Register;

public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
        //Arrange
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseBuilder.Build();

        //Act
        var result = validator.Validate(request);

        //Assert
        result.IsValid.ShouldBeTrue();

    }

    [Fact]
    public void Error_Title_Empty()
    {
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseBuilder.Build();
        request.Title = string.Empty;

        //Act
        var result = validator.Validate(request);

        //Assert
        result.IsValid.ShouldBeFalse();
        result.Errors.ShouldHaveSingleItem().ErrorMessage.ShouldBe(ResourceErrorMessages.TITLE_IS_REQUIRED);
    }
}
