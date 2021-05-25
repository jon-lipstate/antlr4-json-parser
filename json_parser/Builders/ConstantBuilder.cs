using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using antlr_test.Abstract;

namespace antlr_test.Builders
{
    public class ConstantBuilder : IValueBuilder
    {
        private readonly object _constant;

        public ConstantBuilder(object constant)
        {
            _constant = constant;
        }

        public IValue Build() => new ValueImpl(_constant);
    }
}
