using System.Collections.Generic;
using Utilities.com.visualdust.TagSystem;

namespace Utilities.com.visualdust.MessagingSystem
{
    public class IndexedMessageSystem : IMessageSystem
    {
        private List<List<IMessageResolver>> _indexedMessageResolvers = new List<List<IMessageResolver>>();

        private Dictionary<string, List<IMessageResolver>> _indexDictionary =
            new Dictionary<string, List<IMessageResolver>>();

        public void AddResolver() { }

        public void Publish(ISendable message)
        {
            //todo finish this function
        }
    }
}