using System.Collections;
using System.Diagnostics;
using System.Text;

public class Program
{
    public static void Main()
    {
        var max = 1_000_000;
        var searchElement = 496753;
        var stopwatch = new Stopwatch();

        var stringBuilderList = new StringBuilder();
        var stringBuilderArrayList = new StringBuilder();
        var stringBuilderLinkedList = new StringBuilder();
        
        // Создать коллекции List, ArrayList и LinkedList.
        var list = new List<int>();
        var arrayList = new ArrayList();
        var linkedList = new LinkedList<int>();
        
        var resultList = SpeedCreateList(stringBuilderList, stopwatch, list, max, searchElement);
        var resultArrayList = SpeedCreateArrayList(stringBuilderArrayList, stopwatch, arrayList, max, searchElement);
        var resultLinkedList = SpeedCreateLinkedList(stringBuilderLinkedList, stopwatch, linkedList, max, searchElement);
        
        Console.Clear();
        Console.WriteLine(resultList);
        Console.WriteLine(resultArrayList);
        Console.WriteLine(resultLinkedList);
        
    }

    public static string SpeedCreateList(StringBuilder _stringList, Stopwatch _timeList, List<int> _list, int _maxInt, int _search)
    {
        //List - создать
        _timeList.Start();
        for (int i = 1; i <= _maxInt; i++)
        {
            _list.Add(i);
        }
        _timeList.Stop();
        _stringList.Append($"List: Время создания - {_timeList.ElapsedMilliseconds} мс\n");
        
        //List - найти 496753-ий
        _timeList.Start();
        var itemList = _list.Contains(_search);
        _timeList.Stop();
        _stringList.Append($"List: Время поиска {_search}={itemList} - {_timeList.ElapsedMilliseconds} мс\n");
        
        //List - без остатка делится на 777
        _timeList.Start();
        foreach (var l in _list)
        {
            if (l % 777 == 0)
            {
                Console.WriteLine(l);
            }
        }
        _timeList.Stop();
        _stringList.Append($"List: Время поиска элемента который делится без остатка на 777 - {_timeList.ElapsedMilliseconds} мс\n");

        return _stringList.ToString();
    }
    
    public static string SpeedCreateArrayList(StringBuilder _stringArrayList, Stopwatch _timeArrayList, ArrayList _arrayList, int _maxInt, int _search)
    {
        //ArrayList - создать
        _timeArrayList.Start();
        for (int i = 1; i <= _maxInt; i++)
        {
            _arrayList.Add(i);
        }
        _timeArrayList.Stop();
        _stringArrayList.Append($"ArrayList: Время создания - {_timeArrayList.ElapsedMilliseconds} мс\n");
        
        //ArrayList - найти 496753-ий элемент
        _timeArrayList.Start();
        var itemArrayList = _arrayList.Contains(_search);
        _timeArrayList.Stop();
        _stringArrayList.Append($"ArrayList: Время поиска {_search}={itemArrayList} - {_timeArrayList.ElapsedMilliseconds} мс\n");
        
        //ArrayList - без остатка делится на 777
        _timeArrayList.Start();
        foreach (var al in _arrayList)
        {
            if ((int)al % 777 == 0)
            {
                Console.WriteLine(al);
            }
        }
        _timeArrayList.Stop();
        _stringArrayList.Append($"ArrayList: Время поиска элемента который делится без остатка на 777 - {_timeArrayList.ElapsedMilliseconds} мс\n");
        
        return _stringArrayList.ToString();
    }

    public static string SpeedCreateLinkedList(StringBuilder _stringLinkedList, Stopwatch _timeLinkedList, LinkedList<int> _linkedList, int _maxInt, int _search)
    {
        //LinkedList - создать
        _timeLinkedList.Start();
        for (int i = 1; i <= _maxInt; i++)
        {
            _linkedList.AddLast(i);
        }
        _timeLinkedList.Stop();
        _stringLinkedList.Append($"LinkedList: Время создания - {_timeLinkedList.ElapsedMilliseconds} мс\n");
        
        //LinkedList - найти 496753-ий элемент
        _timeLinkedList.Start();
        var itemLinkedList = _linkedList.Contains(_search);
        _timeLinkedList.Stop();
        _stringLinkedList.Append($"LinkedList: Время поиска {_search}={itemLinkedList} - {_timeLinkedList.ElapsedMilliseconds} мс\n");
        
        //LinkedList - без остатка делится на 777
        _timeLinkedList.Start();
        foreach (var ll in _linkedList)
        {
            if (ll % 777 == 0)
            {
                Console.WriteLine(ll);
            }
        }
        _timeLinkedList.Stop();
        _stringLinkedList.Append($"LinkedList: Время поиска элемента который делится без остатка на 777 - {_timeLinkedList.ElapsedMilliseconds} мс\n");

        return _stringLinkedList.ToString();
    }
}
