using Core.Operations.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Core.Operations
{
    public class ArrayOperationManager : IArrayOperationService
    {
        public int Len(IEnumerable iterable)
        {
            int counter = 0;
            foreach (var item in iterable)
            {
                counter++;
            }

            return counter;
        }

        public object[] Reverse(object[] iterable)
        {
            int len = Len(iterable);
            int j = len / 2;
            for (int i = 0; i < j; i++)
            {
                var temp = iterable[i];
                iterable[i] = iterable[len - 1];
                iterable[len - 1] = temp;

                len--;
            }

            return iterable;
        }

        public object[] SortByAsc(object[] iterable)
        {
            throw new NotImplementedException();
        }

        public object[] SortByDesc(object[] iterable)
        {
            throw new NotImplementedException();
        }
    }
}
