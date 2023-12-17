using System.Collections;
using System.Diagnostics;
using System.Text;

public class Program
{
    public static void Main()
    {
        const int max = 1_000_000;
        const int searchElement = 496_753;
        const int dividerElement = 777;
        
        var resultList = SpeedCreateList(max, searchElement, dividerElement);
        var resultArrayList = SpeedCreateArrayList(max, searchElement, dividerElement);
        var resultLinkedList = SpeedCreateLinkedList(max, searchElement, dividerElement);
        
        Console.Clear();
        Console.WriteLine(resultList);
        Console.WriteLine(resultArrayList);
        Console.WriteLine(resultLinkedList);
    }

    private static string SpeedCreateList(int maxInt, int searchInt, int divider)
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
        var itemList = list.ElementAt(searchInt);
        timeList.Stop();
        listCreationTime = timeList.Elapsed.TotalMilliseconds;
        
        stringBuilderList.Append($"List: Время поиска {searchInt}={itemList} - {listCreationTime} мс\n");
        
        timeList.Restart();
        //List - без остатка делится на 777
        var sb = new StringBuilder();
        
        foreach (var l in list.Where(l => l % divider == 0))
        {
            sb.Append($"{l}\n");
        }
        
        Console.WriteLine(sb);
        
        timeList.Stop();
        listCreationTime = timeList.Elapsed.TotalMilliseconds;
        
        stringBuilderList.Append($"List: Время поиска элемента который делится без остатка на {divider} - {listCreationTime} мс\n");

        return stringBuilderList.ToString();
    }
    
    private static string SpeedCreateArrayList(int maxInt, int searchInt, int divider)
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
        var itemArrayList = (int)arrayList[searchInt];
        timeArrayList.Stop();
        arrayListCreationTime = timeArrayList.Elapsed.TotalMilliseconds;
        
        stringBuilderArrayList.Append($"ArrayList: Время поиска {searchInt}={itemArrayList} - {arrayListCreationTime} мс\n");
        
        timeArrayList.Restart();
        //ArrayList - без остатка делится на 777
        var sb = new StringBuilder();
        
        foreach (var al in arrayList)
        {
            if ((int)al % divider == 0)
            {
                sb.Append($"{al}\n");
            }
        }
        Console.WriteLine(sb);
        
        timeArrayList.Stop();
        arrayListCreationTime = timeArrayList.Elapsed.TotalMilliseconds;
        
        stringBuilderArrayList.Append($"ArrayList: Время поиска элемента который делится без остатка на {divider} - {arrayListCreationTime} мс\n");
        
        return stringBuilderArrayList.ToString();
    }

    private static string SpeedCreateLinkedList(int maxInt, int searchInt, int divider)
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
        var itemLinkedList = linkedList.ElementAt(searchInt);
        timeLinkedList.Stop();
        linkedListCreationTime = timeLinkedList.Elapsed.TotalMilliseconds;
        
        stringBuilderLinkedList.Append($"LinkedList: Время поиска {searchInt}={itemLinkedList} - {linkedListCreationTime} мс\n");
        
        timeLinkedList.Restart();
        //LinkedList - без остатка делится на 777
        var sb = new StringBuilder();
        
        foreach (var ll in linkedList.Where(ll => ll % divider == 0))
        {
            sb.Append($"{ll}\n");
        }
        Console.WriteLine(sb);
        
        timeLinkedList.Stop();
        linkedListCreationTime = timeLinkedList.Elapsed.TotalMilliseconds;
        
        stringBuilderLinkedList.Append($"LinkedList: Время поиска элемента который делится без остатка на {divider} - {linkedListCreationTime} мс\n");

        return stringBuilderLinkedList.ToString();
    }
}
