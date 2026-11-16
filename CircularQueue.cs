namespace csharp_homework16;

public class CircularQueue<T>
{
    private T[] _items;
    private int _front;
    private int _rear;
    private int _count;

    public CircularQueue(int size)
    {
        if (size <= 0)
            throw new ArgumentException("Size must be greater than zero!");
        _items = new T[size];
        _front = 0;
        _rear = 0;
        _count = 0;
    }
    
    public int Count => _count;
    public int Capacity => _items.Length;
    public bool IsEmpty => Count == 0;
    public bool IsFull => Count == _items.Length;

    public void Enqueue(T item)
    {
        if (IsFull)
            throw new InvalidOperationException("Queue is full");
        _items[_rear] = item;
        _rear = (_rear + 1) % _items.Length;
        _count++;
    }

    public T Dequeue()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Queue is empty");
        T result = _items[_front];
        _items[_front] = default;
        _front = (_front + 1) % _items.Length;
        _count--;
        return result;
    }

    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Queue is empty");
        return _items[_front];
    }

    public void Clear()
    {
        Array.Clear(_items, 0, _items.Length);
        _front = 0;
        _rear = 0;
        _count = 0;
    }
}