using System;

namespace Carrow
{
    public class Result<TResult>
    {
    }
    
    public sealed class Success<TResult> : Result<TResult>
    {
        public TResult Value { get; }

        public Success(TResult value)
        {
            Value = value;
        }
    }
    
    public sealed class Failure<TResult> : Result<TResult>
    {
        public int Code { get; }
        public string Message { get; }
        public Exception Ex { get; }

        public Failure(int code, string message)
        {
            Message = message;
            Code = code;
            Ex = new Exception(message);
        }

        public Failure(int code, string message, Exception ex)
        {
            Message = message;
            Code = code;
            Ex = ex;
        }
    }
    
    
    /// <include file='Docs/Result.xml' path='docs/members[@name="Unit"]/Unit/*'/>
    public readonly struct Unit {}
}