using System;
using System.Collections.Generic;
using System.Text;

public class MyStack<T>
{
    public T[] _item {  get; set; }
    public int _count;
    
    public MyStack(int capacity)
    {
       _item = new T[capacity];
        _count = 0;
    }
    public void push(T item)
    {
        if(_count>= _item.Length)
        {
            return;
        }
        _item[_count]=item;
        _count++;
    }
    public T pop()
    {
        if (_count <= 0)
        {
            return default(T);
        }
        
        return _item[--_count];
    }
    public T Peek()
    {
        return _item[_count-1]; 
    }
    public bool IsEmpty()
    {
        return _item.Length == 0;
    }
}
