using System.Collections.Generic;
using Utilities.com.visualdust.TagSystem;

namespace Utilities.com.visualdust.MessagingSystem
{
    public class IndexedMessageResolver : IMessageResolver
    {
        List<Tag> _conditions = new List<Tag>();
        private int _triggerCount = 0;
        public void MessageArrived() { throw new System.NotImplementedException(); }

        public bool Trig()
        {
            if (_triggerCount == _conditions.Count)
            {
                //todo add action runner here
            }

            return _triggerCount == _conditions.Count;
        }

        public void MessageArrived(ISendable sendable) { throw new System.NotImplementedException(); }
    }
}