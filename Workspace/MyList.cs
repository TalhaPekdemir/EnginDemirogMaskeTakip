using System.Collections;

namespace Workspace;

public class MyList<T> : IEnumerable<T>
{
    // tutulacak asıl liste
    internal T[] _list;


    public MyList()
    {
        _list = [];
    }

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)_list).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _list.GetEnumerator();
    }

    // MyList<int> myList= new MyList<int> { 1, 2, 3 }; 
    // şeklinde çağırılabilmesi için gerekli metot.
    // Dizinin son hali en uzun ve dolu hali olacağından mevcut listeyi bir artırıp
    // eskisinin yeni listeye kopyalanmasını ve aynı zamanda yeni elemanın eklenmesini sağlar.
    public void Add(T item)
    {
        // eski diziyi kopyala
        T[] copyList = (T[])_list.Clone();

        // yeni bir eleman ekleyecek kadar geniş yeni private dizi oluştur
        _list = new T[copyList.Length + 1];

        // Clone metodu shallow copy yaptığından eleman bazında kopyala
        for (int i = 0; i < copyList.Length; i++)
        {
            _list[i] = copyList[i];
        }

        // yeni length'in bir eksiği 
        _list[_list.Length -1] = item;
    }
}
