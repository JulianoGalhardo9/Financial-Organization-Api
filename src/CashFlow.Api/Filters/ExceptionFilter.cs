using CashFlow.Communication.Responses;
using CashFlow.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using CashFlow.Exception;


namespace CashFlow.Api.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if(context.Exception is CashFlowException)
            {
                HandlerProjectException(context);
            }
            else
            {
                ThrowUnknowError(context);
            }
        }

        private void HandlerProjectException(ExceptionContext context)
        {
            if (context.Exception is ErrorOnValidationException errorOnValidationException)
            {
                var errorResponse = new ResponseErrorJson(errorOnValidationException.Errors);

                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Result = new BadRequestObjectResult(errorResponse);
            }
            else if(context.Exception is NotFoundException notFoundException)
            {
                var errorResponse = new ResponseErrorJson(notFoundException.Message);

                context.HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                context.Result = new NotFoundObjectResult(errorResponse);
            }
            else
            {
                var errorResponse = new ResponseErrorJson(context.Exception.Message);

                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Result = new BadRequestObjectResult(errorResponse);
            }
        }

        private void ThrowUnknowError(ExceptionContext context)
        {
            var errorResponse = new ResponseErrorJson(ResourceErrorMessages.UNKNOWN_ERROR);

            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(errorResponse);
        }
    }
}

