namespace Core5WEBAPI.Helpers
{
    public class ShoppingCart
    {
        INotifier _notifier;

        public ShoppingCart(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void PlaceOrder(string customerEmail, string orderInfo)
        {
            _notifier.Send("admin@store.com", customerEmail, $"Order Placed", $"Thank you for your order of {orderInfo}");
        }

    }
}
