namespace _4.Stack;

public class Stack
{
    private readonly List<string?> _listStack = new List<string?>();
    
    public Stack(params string?[] elementsStack)
    {
        foreach (var element in elementsStack)
        {
            _listStack.Add(element);
        }
    }
    public int Size()
    {
        return _listStack.Count;
    }
    public void Add(string? element)
    {
        _listStack.Add(element);
    }
    public string? Top()
    {
        return _listStack.Count <= 0 ? null : _listStack.Last();
    }
    public string? Pop()
    {
        if (_listStack.Count <= 0) return null;
        var lastElementDelete = _listStack.Last();
        _listStack.RemoveAt(_listStack.Count - 1);
        return lastElementDelete;
    }

    public static IEnumerable<string?> Concat(params Stack[] arrayStack)
    {
        var newStack = new List<string?>();
        var countArrayStack = arrayStack.Length;
        
        for (var i = 0; i < countArrayStack; i++)
        {
            var countElements = arrayStack[i].Size();
            for (var k = 0; k < countElements; k++)
            {
                newStack.Add(arrayStack[i].Top());
                arrayStack[i].Pop();
            }
        }

        return newStack;
    }
    
}