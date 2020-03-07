using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DryCleaningAPI.Exceptions
{
    public sealed class DryCleaningException : Exception
    {
        public DryCleaningException(HttpStatusCode statusCode)
            => HttpStatusCode = statusCode;

        public DryCleaningException(HttpStatusCode statusCode, string message) : base(message)
            => HttpStatusCode = statusCode;

        public DryCleaningException(HttpStatusCode statusCode, string message, Exception innerException) : base(message, innerException)
            => HttpStatusCode = statusCode;

        /// <summary>
        /// Http status code of GitLab response.
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; }
    }
}
