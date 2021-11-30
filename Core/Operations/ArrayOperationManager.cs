using Core.Operations.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Core.Operations
{
    public class ArrayOperationManager : IArrayOperationService
    {
        public int IndexOf<T>(T[] iterable, object data)
        {
            int index = 0;
            foreach (object item in iterable)
            {
                bool condition = item.ToString() == data.ToString();
                if (condition)
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public int IndexOf<T>(T[] iterable, int startIndex, object data)
        {
            int len = Len(iterable);
            if (startIndex >=len)
            {
                return -2; // Başlangıç index'i, dizi boyutundan büyük veya eşit olamaz.
            }

            for (int i = startIndex; i < len; i++)
            {
                bool condition = iterable[i].ToString() == data.ToString();
                if (condition)
                {
                    return i;
                }
            }

            return -1;
        }

        public int IndexOf(object[] iterable, object data)
        {
            return IndexOf<object>(iterable, data);
        }

        public int IndexOf(object[] iterable, int startIndex, object data)
        {
            return IndexOf<object>(iterable, startIndex, data);
        }

        public int RIndexOf<T>(T[] iterable, object data)
        {
            int len = Len(iterable);
            T[] rArray = Reverse(iterable);
            int index = IndexOf<T>(iterable, data);
            return len - (index + 1);
        }

        public int RIndexOf<T>(T[] iterable, int startIndex, object data)
        {
            int len = Len(iterable);
            T[] rArray = Reverse(iterable);
            int index =  IndexOf<T>(rArray, startIndex, data);
            return len - (index + 1);
        }
        public int RIndexOf(object[] iterable, object data)
        {
            return RIndexOf<object>(iterable, data);
        }

        public int RIndexOf(object[] iterable, int startIndex, object data)
        {
            return RIndexOf<object>(iterable, startIndex ,data);
        }

        public int Len(IEnumerable iterable)
        {
            int counter = 0;
            foreach (var item in iterable)
            {
                counter++;
            }

            return counter;
        }

        public T[] Reverse<T>(T[] iterable)
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

        public object[] Reverse(object[] iterable)
        {
            return Reverse<object>(iterable);
        }

        public void SortByAsc(decimal[] iterable)
        {
            int len = Len(iterable);
            for (int i = 0; i < len-1; i++)
            {
                for (int j = 1; j < len; j++)
                {
                    if (i>j)
                    {
                        var temp = iterable[i];
                        iterable[i] = iterable[j];
                        iterable[j] = temp;
                    }
                }
            }
        }

        public void SortByDesc(decimal[] iterable)
        {
            SortByAsc(iterable);
            Reverse(iterable);
        }

        public void SortByAsc(int[] iterable) // Bu method için soyutlama yapamadım ya :..(
        {
            int len = Len(iterable);
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = i+1; j < len; j++)
                {
                    if (iterable[i] > iterable[j])
                    {
                        var temp = iterable[i];
                        iterable[i] = iterable[j];
                        iterable[j] = temp;
                    }
                }
            }
        }

        public void SortByDesc(int[] iterable)
        {
            SortByAsc(iterable);
            Reverse(iterable);
        }
    }
}
