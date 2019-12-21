using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace Utilities
{
    public class Id
    {
        Guid _guid;
        DateTime _timeStamp;
        Object _generator;

        public Id(Object obj = null, Guid? guid = null)
        {
            _guid = guid ?? Guid.NewGuid();
            this._generator = obj;
            _timeStamp = DateTime.Now;
        }

        public T TryToGetGeneratorAs<T>() where T : class
            => _generator as T;

        // public Object TryToGetGeneratorAs(List<Type> possibleTypes, out Type type)
        // {
        //     
        // }

        public override string ToString()
            => this._guid.ToString();
    }
}