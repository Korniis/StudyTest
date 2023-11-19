namespace MailService
{
    public interface IMailService
    {
        public void send(string title, string to, string body);
    }
}