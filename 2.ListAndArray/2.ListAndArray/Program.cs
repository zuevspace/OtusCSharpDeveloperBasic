using System.Collections;
using System.Diagnostics;
using System.Text;

public class Program
{
    public static void Main()
    {
        const int max = 1_000_000;
        const int searchElement = 496_753;
        
        var resultList = SpeedCreateList(max, searchElement);
        var resultArrayList = SpeedCreateArrayList(max, searchElement);
        var resultLinkedList = SpeedCreateLinkedList(max, searchElement);
        
        Console.Clear();
        Console.WriteLine(resultList);
        Console.WriteLine(resultArrayList);
        Console.WriteLine(resultLinkedList);
    }

    private static string SpeedCreateList(int maxInt, int searchInt)
    {
        //List - создать
        var list = new List<int>();
        var stringBuilderList = new StringBuilder();
        var timeList = new Stopwatch();

        timeList.Start();
        for (var i = 1; i <= maxInt; i++)
        {
            list.Add(i);
        }
        timeList.Stop();
        var listCreationTime = timeList.Elapsed.TotalMilliseconds;
        
        stringBuilderList.Append($"List: Время создания - {listCreationTime} мс\n");
        
        timeList.Restart();
        //List - найти 496753-ий
        timeList.Start();
        var itemList = list.Contains(searchInt);
        timeList.Stop();
        listCreationTime = timeList.Elapsed.TotalMilliseconds;
        
        stringBuilderList.Append($"List: Время поиска {searchInt}={itemList} - {listCreationTime} мс\n");
        
        timeList.Restart();
        //List - без остатка делится на 777
        timeList.Start();
        foreach (var l in list.Where(l => l % 777 == 0))
        {
            Console.WriteLine(l);
        }
        timeList.Stop();
        listCreationTime = timeList.Elapsed.TotalMilliseconds;
        
        stringBuilderList.Append($"List: Время поиска элемента который делится без остатка на 777 - {listCreationTime} мс\n");

        return stringBuilderList.ToString();
    }
    
    private static string SpeedCreateArrayList(int maxInt, int searchInt)
    {
        //ArrayList - создать
        var arrayList = new ArrayList();
        var stringBuilderArrayList = new StringBuilder();
        var timeArrayList = new Stopwatch();
        
        timeArrayList.Start();
        for (var i = 1; i <= maxInt; i++)
        {
            arrayList.Add(i);
        }
        timeArrayList.Stop();
        var arrayListCreationTime = timeArrayList.Elapsed.TotalMilliseconds;
        
        stringBuilderArrayList.Append($"ArrayList: Время создания - {arrayListCreationTime} мс\n");
        
        timeArrayList.Restart();
        //ArrayList - найти 496753-ий элемент
        timeArrayList.Start();
        var itemArrayList = arrayList.Contains(searchInt);
        timeArrayList.Stop();
        arrayListCreationTime = timeArrayList.Elapsed.TotalMilliseconds;
        
        stringBuilderArrayList.Append($"ArrayList: Время поиска {searchInt}={itemArrayList} - {arrayListCreationTime} мс\n");
        
        timeArrayList.Restart();
        //ArrayList - без остатка делится на 777
        timeArrayList.Start();
        foreach (var al in arrayList)
        {
            if ((int)al % 777 == 0)
            {
                Console.WriteLine(al);
            }
        }
        timeArrayList.Stop();
        arrayListCreationTime = timeArrayList.Elapsed.TotalMilliseconds;
        
        stringBuilderArrayList.Append($"ArrayList: Время поиска элемента который делится без остатка на 777 - {arrayListCreationTime} мс\n");
        
        return stringBuilderArrayList.ToString();
    }

    private static string SpeedCreateLinkedList(int maxInt, int searchInt)
    {
        //LinkedList - создать
        var linkedList = new LinkedList<int>();
        var stringBuilderLinkedList = new StringBuilder();
        var timeLinkedList = new Stopwatch();
        
        timeLinkedList.Start();
        for (var i = 1; i <= maxInt; i++)
        {
            linkedList.AddLast(i);
        }
        timeLinkedList.Stop();
        var linkedListCreationTime = timeLinkedList.Elapsed.TotalMilliseconds;
        
        stringBuilderLinkedList.Append($"LinkedList: Время создания - {linkedListCreationTime} мс\n");
        
        timeLinkedList.Restart();
        //LinkedList - найти 496753-ий элемент
        timeLinkedList.Start();
        var itemLinkedList = linkedList.Contains(searchInt);
        timeLinkedList.Stop();
        linkedListCreationTime = timeLinkedList.Elapsed.TotalMilliseconds;
        
        stringBuilderLinkedList.Append($"LinkedList: Время поиска {searchInt}={itemLinkedList} - {linkedListCreationTime} мс\n");
        
        timeLinkedList.Restart();
        //LinkedList - без остатка делится на 777
        timeLinkedList.Start();
        foreach (var ll in linkedList.Where(ll => ll % 777 == 0))
        {
            Console.WriteLine(ll);
        }
        timeLinkedList.Stop();
        linkedListCreationTime = timeLinkedList.Elapsed.TotalMilliseconds;
        
        stringBuilderLinkedList.Append($"LinkedList: Время поиска элемента который делится без остатка на 777 - {linkedListCreationTime} мс\n");

        return stringBuilderLinkedList.ToString();
    }
}
