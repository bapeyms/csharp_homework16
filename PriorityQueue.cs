namespace csharp_homework16;

public class PriorityQueue<T>
{
    private List<(T Item, int Priority)> items = new List<(T Item, int Priority)>();
    
    public int Count => items.Count;
    public bool IsEmpty => items.Count == 0;
    public void Enqueue(T item, int priority) => items.Add((item, priority));

    public T Dequeue()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Queue is empty!");
        int maxIndex = 0;
        for (int i = 1; i < items.Count; i++)
        {
            if (items[i].Priority > items[maxIndex].Priority)
                maxIndex = i;
        }
        T result = items[maxIndex].Item;
        items.RemoveAt(maxIndex);
        return result;
    }

    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Queue is empty!");
        int maxIndex = 0;
        for (int i = 1; i < items.Count; i++)
        {
            if (items[i].Priority > items[maxIndex].Priority)
                maxIndex = i;
        }
        return items[maxIndex].Item;
    }
    public void Clear() => items.Clear();
}