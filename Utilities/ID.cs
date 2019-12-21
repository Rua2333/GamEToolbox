using System;
using System.Collections.Generic;

namespace Utilities
{
    public class ID
    {
        private Guid _guid = Guid.NewGuid();
        DateTime _dateTime = DateTime.Now;
        private Object _generator;

        public ID(Object obj)
        {
            this._generator = obj;
        }

        public T TryToGetGeneratorAs<T>() where T : class
            => _generator as T;
    }
}