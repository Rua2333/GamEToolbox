namespace Utilities.com.visualdust.Tag
{
    public interface ITagManage
    {
        /// <summary>
        /// method <c>addTag</c> allows you to add a key-value mapping relationship. In another word, add a tag.
        /// </summary>
        /// <param name="tag"></param> is the tag that you want to add
        void addTag(Tag tag);

        /// <summary>
        /// <c>find and remove a tag using a key, also delete it's value</c>
        /// </summary>
        /// <param name="tagKey"></param> is the key of the tag you wanna remove
        void removeTag(string tagKey);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void setValueOfKey(string key, string value);

        /// <summary>
        /// <c>checkIfThereIs</c> allows you to check if there is a key with the name of tag
        /// </summary>
        /// <param name="key"></param> is the key that you want to check
        void checkIfThereIs(string key);

        /// <summary>
        ///<c>getValueOf</c> allows you to get the value of a key in tags
        /// </summary>
        /// <param name="key"></param> Which value to get
        void getValueOf(string key);
    }
}