using System;
using System.Collections.Generic;

namespace Utilities
{
    public class Id
    {
        Guid _guid;
        DateTime _dateTime = DateTime.Now;
        Object _generator;

        public Id(Object obj, Guid? guid = null)
        {
            _guid = guid ?? Guid.NewGuid();
            this._generator = obj;
        }

        public T TryToGetGeneratorAs<T>() where T : class
            => _generator as T;
    }
}