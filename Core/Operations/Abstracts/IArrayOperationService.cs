using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Core.Operations.Abstracts
{
    public interface IArrayOperationService
    {
        int Len(IEnumerable iterable);
        object[] Reverse(object[] iterable);
        object[] SortByAsc(object[] iterable);
        object[] SortByDesc(object[] iterable);
    }
}
