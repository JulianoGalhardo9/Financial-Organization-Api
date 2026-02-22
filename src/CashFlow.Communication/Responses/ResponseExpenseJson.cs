namespace CashFlow.Communication.Responses
{
	public class ResponseExpenseJson
	{
        public List<ResponseShortExpenseJson> Expenses { get; set; } = new List<ResponseShortExpenseJson>();
    }
}

