using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;
using CashFlow.Exception.ExceptionsBase;
using CashFlow.Domain.Enums;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Domain.Repositories;

namespace CashFlow.Application.UseCases.Expenses.Register
{
	public class RegisterExpenseUseCase : IRegisterExpenseUseCase
    {

        private readonly IExpensesRepositories _repository;
        private readonly IUnitOfWork _unitOfWork;

        public RegisterExpenseUseCase(IExpensesRepositories repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

		public async Task<ResponseRegisteredExpenseJson> Execute(RequestRegisterExpenseJson request)
		{
            Validate(request);


            var entity = new Expense
            {
                Amount = request.Amount,
                Date = request.Date,
                Description = request.Description,
                Title = request.Title,
                PaymentType = (PaymentType)request.PaymentType,
            };

            await _repository.Add(entity);

            await _unitOfWork.Commit();

            return new ResponseRegisteredExpenseJson();

        }

		private void Validate(RequestRegisterExpenseJson request)
		{
			var validator = new RegisterExpenseValidator();

			var result = validator.Validate(request);

			if (result.IsValid == false)
			{
                var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();

				throw new ErrorOnValidationException(errorMessages);
            }
        }
	}
}

