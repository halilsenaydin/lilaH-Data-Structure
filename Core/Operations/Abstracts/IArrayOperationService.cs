using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Core.Operations.Abstracts
{
    public interface IArrayOperationService
    {
        int Len(IEnumerable iterable);

        // Reverse
        object[] Reverse(object[] iterable);
        T[] Reverse<T>(T[] iterable);


        // Index Of
        int IndexOf<T>(T[] iterable, object data);
        int IndexOf<T>(T[] iterable, int startIndex, object data);
        int IndexOf(object[] iterable, object data);
        int IndexOf(object[] iterable, int startIndex, object data);

        // Reverse Index Of
        int RIndexOf<T>(T[] iterable, object data); 
        int RIndexOf<T>(T[] iterable, int startIndex, object data);
        int RIndexOf(object[] iterable, object data);
        int RIndexOf(object[] iterable, int startIndex, object data);

        // Sort
        void SortByAsc(int[] iterable);
        void SortByDesc(int[] iterable);

        void SortByAsc(decimal[] iterable);
        void SortByDesc(decimal[] iterable);
    }
}
