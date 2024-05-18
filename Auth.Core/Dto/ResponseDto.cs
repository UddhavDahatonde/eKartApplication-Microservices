namespace Auth.Core.Dto
{
    public class ResponseDto
    {
        public string? Message { get; set; } = "";
        public object? Result { get; set; }
        public bool Status { get; set; } = true;
    }
}
