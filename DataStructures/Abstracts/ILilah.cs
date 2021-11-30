using Core.Utilities.Results.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Abstracts
{
    public interface ILilah<T>:IEnumerable<T>
    {
        public int Len { get; }
        public T[] array { get; set; }

        IResult Append(T data);
        void Insert(T data, int indexNumber);
        IResult Extend(ILilah<T> data);

        bool IsBeenInList(T data);
        int Count(T data);

        IResult Remove(int indexNumber);
        IResult Remove(object item);
        void RemoveAll();
        T Pop(int indexNumber = 0);

        IResult Update(int index, T set);

        void Show();
        void Show(int startIndex);
        void Show(int startIndex, int count);

        T Find(int indexNumber);
        ILilah<object> Find(T item);
        ILilah<object> Find(params T[] items);

        void Reverse();
        IDataResult<int> IndexOf(T data);
    }
}
