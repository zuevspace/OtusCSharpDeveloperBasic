namespace _4.Stack;

public class Stack
{
    private List<string?> _listStack = new List<string?>();
    
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
        _listStack.RemoveAt(0);
        return lastElementDelete;

    }
}