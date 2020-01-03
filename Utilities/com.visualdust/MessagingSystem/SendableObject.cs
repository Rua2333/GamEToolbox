using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.com.visualdust.TagSystem;

namespace Utilities.com.visualdust.MessagingSystem
{
    public class SendableObject : ISendable
    {
        private List<object> _attachments;
        private InfoExtention _extention = new InfoExtention();
        public SendableObject(object sender, string message) { }

        public SendableObject AddTag(Tag tag)
        {
            this._extention.addTag(tag);
            return this;
        }

        public void AddAttachment(object attachment) => _attachments.Add(attachment);
        public object GetSender() { throw new System.NotImplementedException(); }
        public string GetMessage() { throw new System.NotImplementedException(); }
        public object GetAttachment() { throw new System.NotImplementedException(); }
    }
}