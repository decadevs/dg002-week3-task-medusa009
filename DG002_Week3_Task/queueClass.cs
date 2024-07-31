using System;
using System.Collections.Generic;

public class Queue<T>
{
    private LinkedList<T> _items;

    public Queue()
    {
        _items = new LinkedList<T>();
    }

    public bool IsEmpty()
    {
        return _items.Count == 0;
    }

    public void Enqueue(T item)
    {
        _items.AddLast(item);
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Get the first item
        T value = _items.First.Value;
        // Remove the first item
        _items.RemoveFirst();
        return value;
    }

    public int Size()
    {
        return _items.Count;
    }
}

