using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWatch.Services.Errors
{
    public interface IErrorHandlingService
    {
        Task<string> HandleExceptionAsync(Exception ex);
        Task<string> GenerateErrorReportAsync(Exception ex);
        string GetExceptionDetails(Exception ex);
        string GetCustomErrorMessage(string errorKey);
        void LogException(Exception ex);
    }

    public class ErrorHandlingService : IErrorHandlingService
    {
    }
}
