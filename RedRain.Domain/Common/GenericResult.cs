using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedRain.Domain.Common
{
    public class GenericResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericResult"/> class.
        /// </summary>
        public GenericResult() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericResult"/> class.
        /// </summary>
        /// <param name="statusCode">The status code.</param>
        /// <param name="success">if set to <c>true</c> [success].</param>
        /// <param name="title">The title.</param>
        /// <param name="message">The message.</param>
        /// <param name="data">The data.</param>
        public GenericResult(int statusCode, bool success, string title, string message, object data)
        {
            Success = success;
            StatusCode = statusCode;
            Title = title;
            Message = message;
            Data = data;
        }
        public bool Success { get; set; }
        public int StatusCode { get; }
        public string Title { get; }
        public string Message { get; }
        public object Data { get; }
    }
}
