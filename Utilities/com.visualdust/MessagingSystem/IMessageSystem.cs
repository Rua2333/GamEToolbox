namespace Utilities.com.visualdust.MessagingSystem
{
    public interface IMessageSystem
    {
        void Publish(ISendable message);
    }
}