using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using antlr_test.Abstract;

namespace antlr_test.Builders
{
    internal class ValueImpl : IValue
    {
        private static readonly IValue Null = new ValueImpl((object)null);
        private readonly List<IValue> _array = new List<IValue>();
        private readonly Dictionary<string, IValue> _objects = new Dictionary<string, IValue>();


        public object Value { get; }

        public IValue this[int index] => index < _array.Count ? _array[index] : Null;

        public IValue this[string key]
        {
            get
            {
                IValue value;
                return _objects.TryGetValue(key, out value) ? value : Null;
            }
        }

        public ValueImpl(object value)
        {
            Value = value;
        }

        public ValueImpl(IEnumerable<IValue> arr) => _array = arr.ToList();

        public ValueImpl(IDictionary<string, IValue> dict) =>
            _objects = dict.ToDictionary(kv => kv.Key, kv => kv.Value);

        public IEnumerator<IValue> GetEnumerator() => _array.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
