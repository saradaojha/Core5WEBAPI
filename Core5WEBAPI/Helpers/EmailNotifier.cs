namespace Core5WEBAPI.Helpers
{
    public class EmailNotifier : INotifier
    {
        public void Send(string from, string to, string subject, string body)
        {
            // TODO: Connect to something that will send an email.
        }
    }
}
