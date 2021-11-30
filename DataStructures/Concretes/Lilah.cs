using Core.Operations;
using Core.Operations.Abstracts;
using Core.Utilities;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataStructures.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Concretes
{
    public class Lilah<T> : ILilah<T> //where T: class, new()
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

        public IResult Append(T data)
        {
            List<IResult> rules = new List<IResult>() // List veri yapısını kullanmalıyım :..( Overload yapabilirim ama core katmanına, katmanlarımdan birini referans vermek istemedim. 
            {
                ItemMustHaveNotEmpty(data)
            }; 

            var result =  RulesRuner.Run(rules);
            if (!result.Success)
            {
                return new ErrorResult(result.Message);
            }

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

            return new SuccessResult();
        }

        public void Insert(T data, int indexNumber)
        {
            throw new NotImplementedException();
        }

        public IResult Extend(ILilah<T> data)
        {
            foreach (var item in data.array)
            {
                var result = Append(item);
                if (!result.Success)
                {
                    return new ErrorResult(result.Message);
                }
            }

            return new SuccessResult();
        }

        public IResult Remove(int indexNumber) // index numarası ile silme..
        {
            List<IResult> rules = new List<IResult>()
            {
                IndexNumberMustNotSmallerThanArraySize(indexNumber, Len)
            };

            var result = RulesRuner.Run(rules);
            if (!result.Success)
            {
                return new ErrorResult(result.Message);
            }

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
            return new SuccessResult();
        }

        public IResult Remove(object item) // Verilen item dizi de varsa siler, birden fazla varsa hepsini siler.
        {
            int len = _arrayOperation.Len(array);
            var foundLen = _arrayOperation.Len(Find((T)item));

            int newLen = len - foundLen;
            T[] tempArray = new T[newLen]; // Array boyutunu azalt..

            int counter = 0;
            foreach (var i in array)
            {
                if ((object)i == item)
                {
                    continue;
                }

                tempArray[counter] = i;
                counter++;
            }

            array = tempArray;
            return new SuccessResult();
        }

        public void RemoveAll()
        {
            int len = _arrayOperation.Len(array);
            for (int i = 0; i < len; i++)
            {
                Remove(i);
            }
        }

        public T Pop(int indexNumber = 0)
        {
            var found = Find(indexNumber);
            Remove(indexNumber);
            return found;
        }

        public IResult Update(int index, T set)
        {
            array[index] = set;
            return new SuccessResult();
        }

        public T Find(int indexNumber) // verilen index numarasına göre item'i döner.
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

        public ILilah<object> Find(T item) // Bulunan item'leri ve item'lerin index numarasını döner. List of list..
        {
            ILilah<object> lilah = new Lilah<object>();

            int index = 0;
            foreach (var i in array)
            {
                if (i.ToString() == item.ToString())
                {
                    ILilah<object> data = new Lilah<object>(item, index);
                    lilah.Append(data);
                }

                index++;
            }

            return lilah;
        }

        public ILilah<object> Find(params T[] items) // Bulunması istenen birden fazla item'leri ve index'lerini döndürür. 3 boyutlu lilahList döner..
        {
            ILilah<object> lilah = new Lilah<object>(); // [[[item, index], [item, index]]]: [[ilk değer için bulunanlar], [ikinci değer için bulunanlar]]: [bulunanlar] --> Bu yüzden 3 boyutlu olması gerekiyor..
            foreach (var item in items)
            {
                int index = 0;
                ILilah<object> foundValues = new Lilah<object>();
                foreach (var i in array)
                {
                    if ((object)i == (object)item)
                    {
                        ILilah<object> data = new Lilah<object>(item, index);
                        foundValues.Append(data);
                    }

                    index++;
                }

                lilah.Append(foundValues);
            }

            return lilah;
        }

        public void Reverse()
        {
            _arrayOperation.Reverse<T>(array);
        }

        public IDataResult<int> IndexOf(T data)
        {
            List<IResult> rules = new List<IResult>()
            {
                ItemMustHaveNotEmpty(data)
            };

            var result = RulesRuner.Run(rules);
            if (!result.Success)
            {
                return new ErrorDataResult<int>(result.Message);
            }

            var index = _arrayOperation.IndexOf<T>(array, data);
            return new SuccessDataResult<int>(index);
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

        public bool IsBeenInList(T data)
        {
            var found = Find(data);
            int len = _arrayOperation.Len(found);
            if (len == 0)
            {
                return false; // Liste içinde yok.
            }

            return true; // Liste içinde var.
        }

        public int Count(T data) // Liste içinde kaç kere geçiyor..
        {
            var found = Find(data);
            return _arrayOperation.Len(found);
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

        private IResult ItemMustHaveNotEmpty(T item)
        {
            if ((object)item == (object)0 || (object)item == (object)"")
            {
                return new ErrorResult("Boş bir değer lilah listesine eklenemez!");
            }

            return new SuccessResult();
        }
    }
}
