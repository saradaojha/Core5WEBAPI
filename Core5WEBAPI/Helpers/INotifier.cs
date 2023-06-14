namespace Core5WEBAPI.Helpers
{
    public interface INotifier
    {
        void Send(string from, string to, string subject, string body);
    }
}
