using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Infrastructure.DataAcess.Repositories
{
    internal class ExpensesRepository : IExpensesRepositories
    {

        private readonly CashFlowDbContext _dbContext;

        public ExpensesRepository(CashFlowDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Expense expense)
        {

            _dbContext.Expenses.Add(expense);

            _dbContext.SaveChanges();
        }
    }
}

