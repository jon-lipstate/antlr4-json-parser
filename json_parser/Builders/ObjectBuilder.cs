using System;
using System.Collections.Generic;
using System.Linq;
using antlr_test.Abstract;

namespace antlr_test.Builders
{
    public class ObjectBuilder : IValueBuilder
    {
        private Dictionary<string, IValueBuilder> _builders;
        public void SetProperty(string key, IValueBuilder builder) => _builders.Add(key, builder);

        public ObjectBuilder()
        {
            _builders = new Dictionary<string, IValueBuilder>();
        }
        public IValue Build() => new ValueImpl(_builders.ToDictionary(kv=>kv.Key, kv=>kv.Value.Build()));
    }
}
