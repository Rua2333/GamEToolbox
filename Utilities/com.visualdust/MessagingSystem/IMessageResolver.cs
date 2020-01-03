using System.Collections.Generic;
using Utilities.com.visualdust.TagSystem;

namespace Utilities.com.visualdust.MessagingSystem
{
    public interface IMessageResolver
    {
        void MessageArrived(ISendable sendable);
    }
}