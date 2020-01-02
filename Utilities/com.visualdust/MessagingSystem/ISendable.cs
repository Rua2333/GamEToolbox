using System;

namespace Utilities.com.visualdust.MessagingSystem
{
    public interface ISendable
    {
        Object GetSender();
        String GetMessage();
        
    }
}