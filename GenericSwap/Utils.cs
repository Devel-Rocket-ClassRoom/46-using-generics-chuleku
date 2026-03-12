using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Utils
{
    public static void Swap<T>(ref T a, ref T b)
    {
        var temp = a;
        a = b;
        b = temp;
    }
    public static void SwapInArray<T>(T[] array, int index1, int index2)
    {
        var temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
    public static T FindMin<T>(T[] array)where T : IComparable<T>
    {
        T min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].CompareTo(min)<0)   
            {
                min = array[i];
            }
        }
        return min;
    }
    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        T Max = array[0];
        for (int i = 0;i < array.Length;i++)
        {
            if(array[i].CompareTo(Max)>0)
            {
                Max = array[i]; 
            }
        }
        return Max;
    }
    public static void Reverse<T>(T[] array)
    {
        int start = 0;
        int end = array.Length - 1;

        while (start < end)
        {
            SwapInArray(array, start, end);
            start++;
            end--;
        }
    }
}