using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Repositories.Expenses
{
	public interface IExpensesRepositories
	{
        Task Add(Expense expense);
		Task<List<Expense>> GetAll();
	}
}

