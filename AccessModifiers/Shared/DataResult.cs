namespace Shared
{
    public class DataResult
    {
        public DataResult(bool success, string message, object obj)
        {
            Success = success;
            Message = message;
            Object = obj;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Object { get; set; }
    }
}