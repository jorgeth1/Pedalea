using FantasyEventRoom.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace Pedalea.Api.Filtros
{
    [AttributeUsage(AttributeTargets.All)]
    public sealed class AppExceptionFilterAttribute : ExceptionFilterAttribute
    {
        private readonly ILogger<AppExceptionFilterAttribute> _logger;

        public AppExceptionFilterAttribute(ILogger<AppExceptionFilterAttribute> logger)
        {
            _logger = logger;
        }

        public override void OnException(ExceptionContext context)
        {
            if (context is not null)
            {
                context.HttpContext.Response.StatusCode = context.Exception switch
                {
                    PedaleaException => (int)HttpStatusCode.BadRequest,
                    _ => (int)HttpStatusCode.InternalServerError
                };

                _logger.LogError(context.Exception, context.Exception.Message, new[] { context.Exception.StackTrace });

                var exceptionMessage = new
                {
                    context.Exception.Message
                };

                context.Result = new ObjectResult(exceptionMessage);
            }

        }
    }
}
