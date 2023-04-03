using System.Collections.Generic;
using System;

namespace TG.ECommerce.Shared.Responses
{
    public class Response<T>
    {
        public Response(ResultStatus resultStatus, T data)
        {
            ResultStatus = resultStatus;
            Data = data;
        }
        public Response(ResultStatus resultStatus, string message, T data)
        {
            ResultStatus = resultStatus;
            Message = message;
            Data = data;
        }
        public Response(ResultStatus resultStatus, string message)
        {
            ResultStatus = resultStatus;
            Message = message;
        }

        public ResultStatus ResultStatus { get; }
        public string Message { get; }
        public T Data { get; }
    }
}
