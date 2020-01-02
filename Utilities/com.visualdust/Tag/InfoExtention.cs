using System.Collections.Generic;

namespace Utilities.com.visualdust.Tag
{
    /**
    * @author VisualDust
    * @since 0.0.0.1
    * last update on 20191229
    */
    public class InfoExtention : ITagManage
    {
        private Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public void addTag(Tag tag) => addTag(tag.key, tag.value);

        public void addTag(string key, string value) { _dictionary.Add(key, value); }

        public void removeTag(string tagKey)
        {
            if (!_dictionary.Remove(tagKey))
            {
                //todo add exception resolver
            }
        }

        public void setValueOfKey(string key, string value) { throw new System.NotImplementedException(); }

        public void checkIfThereIs(string key) { throw new System.NotImplementedException(); }

        public void getValueOf(string key) { throw new System.NotImplementedException(); }
    }
}