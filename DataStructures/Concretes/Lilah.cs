using Core.Operations;
using Core.Operations.Abstracts;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataStructures.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Concretes
{
    public class Lilah<T> : ILilah<T> // Python'daki list, C#'daki ArrayList
    {
        IArrayOperationService _arrayOperation = new ArrayOperationManager();
        public int Len { get => GetLength(); } // Her çağrılışta boyutu yeniden hesapla..
        public T[] array { get; set; }

        public Lilah()
        {
            array = new T[0];
        }

        public Lilah(params T[] items)
        {
            int len = _arrayOperation.Len(items);
            array = new T[len];

            int i = 0;
            foreach (var item in items)
            {
                array[i] = item;
                i++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private int GetLength()
        {
            return _arrayOperation.Len(array);
        }

        public void Add(T data)
        {
            int len = _arrayOperation.Len(array);
            int newLen = len + 1;
            T[] tempArray = new T[newLen]; // Array boyutunu artır..
            for (int i = 0; i < newLen; i++)
            {
                if (i == len)
                {
                    tempArray[i] = data; // Yeni gelen veriyi, dizisini sonuna ekle..
                    array = tempArray;
                    break;
                }

                tempArray[i] = array[i];
            }
        }

        public void Delete(int indexNumber) // index numarası ile silme..
        {
            int len = _arrayOperation.Len(array);
            int newLen = len - 1;
            T[] tempArray = new T[newLen]; // Array boyutunu azalt..
            for (int i = 0; i < newLen; i++)
            {
                if (i == indexNumber)
                {
                    continue;
                }

                tempArray[i] = array[i];
            }

            array = tempArray;
        }

        public void Delete(object item) // object silme (string, int, kullanıcı tanımlı nesne..)
        {
            int len = _arrayOperation.Len(array);
            int newLen = len - 1;
            T[] tempArray = new T[newLen]; // Array boyutunu azalt..

            int counter = 0;
            foreach (var i in array)
            {
                if ((object)i == item)
                {
                    continue;
                }

                tempArray[counter] = i;
            }

            array = tempArray;
        }

        public void DeleteAll()
        {
            foreach (var item in array)
            {
                Delete(item);
            }
        }

        public void Update(T data, T set)
        {
            throw new NotImplementedException();
        }

        public T Find(int indexNumber)
        {
            int len = _arrayOperation.Len(array);
            
            var found = array[0];
            for (int i = 0; i < len; i++)
            {
                if (i == indexNumber)
                {
                    found = array[i];
                    break;
                }
            }

            return found;
        }

        public ILilah<T> Find(T item)
        {
            ILilah<T> lilah = new Lilah<T>();
            foreach (var i in array)
            {
                if ((object)i == (object)item)
                {
                    lilah.Add(item);
                }
            }

            return lilah;
        }

        public ILilah<T> Find(params T[] items)
        {
            ILilah<T> lilah = new Lilah<T>();
            foreach (var item in items)
            {
                foreach (var i in array)
                {
                    if ((object)i == (object)item)
                    {
                        lilah.Add(item);
                    }
                }
            }

            return lilah;
        }

        public void Show()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public void Show(int startIndex)
        {
            int len = GetLength();
            for (int i = startIndex; i < len; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void Show(int startIndex, int count)
        {
            int end = startIndex + count;
            for (int i = startIndex; i < end; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private IResult IndexNumberMustNotSmallerThanArraySize(int index, int len)
        {
            if (index >= len || index < 0)
            {
                return new ErrorResult("İndis numarası dizi boyutundan büyük, eşit veya 0'dan küçük olamaz.");
            }

            return new SuccessResult();
        }

        private IResult CountMustNotPassArraySize(int startIndex, int count,  int len)
        {
            int end = startIndex + count;
            if (end >= len)
            {
                return new ErrorResult("Yazdırılacak değerler dizi boyutunu geçmemelidir..");
            }

            return new SuccessResult();
        }
    }
}
