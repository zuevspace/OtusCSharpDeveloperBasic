namespace _4.Stack;

public static class StackExtensions
{
    public static void Merge(this Stack stack, Stack addElements)
    {
        var countElements = addElements.Size();
        for (var i = 0; i < countElements; i++)
        {
            stack.Add(addElements.Top());
            addElements.Pop();
        }
    }
}