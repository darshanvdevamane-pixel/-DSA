using System.Collections.Concurrent;

namespace ConsoleApp1;

class Program
{
    //Linear Search
    public int LinearSearch(int[] A,int n,int key)
    {
        int i = 0;
        while(i<=n)
        {
            if (A[i] == key)
            {
                return i;
            }
            i = i + 1;
        }
        return - 1;
    }

    //Binary Search
    public int BinarySearch(int[] A,int n,int key)
    {
        int l = 0;
        int r = n-1;
        while (l <= r)
        {
            int mid = (l+r) / 2;
            if (A[mid] == key)
            {
                return mid;
            }
            else if (A[mid] < key)
            {
                l = mid + 1;
            }
            else if (A[mid] > key)
            {
                r = mid - 1;
            }
        }
        return -1;
    }
    static void Main(string[] args)
    {
        
        Program p = new Program();
        //Linear Search
        int[] arr = new int[5] {56,76,78,34,7};
        int i = p.LinearSearch(arr, arr.Length, 78);
        //Console.WriteLine($"78 Found at Index: {i}");

        //Binary Search
        int[] arr1 = new int[5] { 78,89,101,788,900};
        Console.WriteLine($"788 Found at index: "+p.BinarySearch(arr1,arr1.Length,788));


    }
}
