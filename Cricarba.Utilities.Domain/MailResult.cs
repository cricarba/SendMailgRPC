namespace Cricarba.Utilities.Domain
{
    public class MailResult
    {
        public StatusType Status { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }

        public static implicit operator MailResult(SendGrid.Response response)
        {
            return new MailResult
            {
                Status = response.IsSuccessStatusCode ? StatusType.Success : StatusType.Fail,
                Error = response.IsSuccessStatusCode,
                Message = response.StatusCode.ToString()
            };
        }
    }
}