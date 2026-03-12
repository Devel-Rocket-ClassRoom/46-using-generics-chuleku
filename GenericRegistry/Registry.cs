using System;
using System.Collections.Generic;
using System.Text;

public class Registry<TKey, TValue> where TKey : IEquatable<TKey>
{
    public TKey[] keys { get; set; }
    public TValue[] values { get; set; }
    private int _count = 0;
    public int Count { get { return _count; } }
    public Registry(int capacity)
    {
        keys = new TKey[capacity];
        values = new TValue[capacity];
    }
    public void Register(TKey key, TValue value)
    {
        for (int i = 0; i < _count; i++)
        {
            if (keys[i].Equals(key))
            {
                values[i] = value;
                return;
            }
        }
        if (Count < keys.Length)
        {
            keys[_count] = key;
            values[_count] = value;
            _count++;
        }

    }
    public TValue Find(TKey key)
    {
        for (int i = 0; i < _count; i++)
        {
            if (keys[i].Equals(key))
            {
                return values[i];
            }
        }
        return default(TValue);
    }
    public bool Contains(TKey key)
    {
        for (int i = 0; i < _count; i++)
        {
            if (keys[i].Equals(key))
            {
                return keys[i].Equals(key);
            }
        }
        return keys.Equals(key);
 
    }
    public void PrintAll()
    {
        for (int i = 0; i < _count; i++)
        {
            Console.WriteLine($"[{keys[i]}] {values[i]}");
        }
    }
}