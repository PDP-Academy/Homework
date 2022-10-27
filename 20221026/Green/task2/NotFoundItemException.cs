namespace task2;

internal class NotFoundItemException : Exception
{
	public string Message { get; set; }
	public NotFoundItemException(string message):base(message)
	{
		Message = message;
	}
}
