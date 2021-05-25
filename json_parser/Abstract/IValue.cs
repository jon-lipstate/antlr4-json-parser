using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antlr_test.Abstract
{
    public interface IValue : IEnumerable<IValue>
    {
        object Value { get; }
        IValue this[int index] { get; }
        IValue this[string key] { get; }
    }
}
