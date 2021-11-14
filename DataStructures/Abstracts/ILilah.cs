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

        void Add(T data);
        void Delete(int indexNumber);
        void Delete(object item);
        void DeleteAll();
        void Update(T data, T set);

        void Show();
        void Show(int startIndex);
        void Show(int startIndex, int count);

        T Find(int indexNumber);
        ILilah<T> Find(T item);
        ILilah<T> Find(params T[] items);
    }
}
