namespace Utilities.com.visualdust.MessagingSystem
{
    public class SendableObject : ISendable
    {
        public object GetSender() { throw new System.NotImplementedException(); }
        public string GetMessage() { throw new System.NotImplementedException(); }
        public object GetAttachment() { throw new System.NotImplementedException(); }
        
    }
}