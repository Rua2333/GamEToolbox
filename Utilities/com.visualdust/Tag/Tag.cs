using System;

namespace Utilities.com.visualdust.Tag
{
    /**
     * @author VisualDust
     * @since 0.0.0.1
     * last update on 20200102
     */
    public class Tag
    {
        public readonly string key, value;

        Tag(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}