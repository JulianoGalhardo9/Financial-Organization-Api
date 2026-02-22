using AutoMapper;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Application.UseCases.Expenses.GetAll
{
	public class GetAllExpenseUseCase : IGetAllExpenseUseCase
    {
		private readonly IExpensesRepositories _repository;
		private readonly IMapper _mapper;

		public GetAllExpenseUseCase(IExpensesRepositories repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

        public async Task<ResponseExpenseJson> Execute()
		{
			var result = await _repository.GetAll();

			return new ResponseExpenseJson
			{
				Expenses = _mapper.Map<List<ResponseShortExpenseJson>>(result)
			};
		}
	}
}

