namespace AppHub.Domain.Responses
{
    public class Result<T>
    {
        public T Data { get; set; } // El resultado (datos)
        public bool IsSuccess { get; set; } // Si fue exitoso o no
        public string Error { get; set; } // Mensaje de error, si aplica

        public static Result<T> Success(T data)
        {
            return new Result<T> { Data = data, IsSuccess = true };
        }

        public static Result<T> Failure(string error)
        {
            return new Result<T> { IsSuccess = false, Error = error };
        }
    }
}
