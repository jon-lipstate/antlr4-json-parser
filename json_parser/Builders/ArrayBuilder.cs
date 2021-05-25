using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using antlr_test.Abstract;

namespace antlr_test.Builders
{
    public class ArrayBuilder : IValueBuilder
    {
        private readonly List<IValueBuilder> _builders;

        public ArrayBuilder()
        {
            _builders = new List<IValueBuilder>();
        }

        public void Push(IValueBuilder builder) => _builders.Add(builder);

        public IValue Build() => new ValueImpl(_builders.Select(x => x.Build()));
    }
}
