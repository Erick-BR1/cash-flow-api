namespace CashFlow.Communication.Reponses;

public class ResponseError
{
    // required para obrigar a mensagem de erro
    public required string ErrorMessage { get; set; } = string.Empty;

    public ResponseError(string errorMessage) { ErrorMessage = errorMessage; }
}
