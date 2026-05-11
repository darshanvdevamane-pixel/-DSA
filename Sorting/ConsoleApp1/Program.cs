namespace ConsoleApp1;

class Program
{
    public void selectionSort(int[]A,int n)
    {
        for (int i = 0; i < n-1; i++) 
        {
            int position = i;
            for (int j = i+1; j < n; j++)
            {
                if (A[j] < A[position])
                {
                    position = j;
                }
            }
            int temp = A[i];
            A[i] = A[position];
            A[position] = temp;
        }
        display(A);
    }

    public void insertionSort(int[] A, int n)
    {
        for(int i = 0;  i < n;i++)
        {
            int temp = A[i];
            int position = i;
            while((position > 0) && (A[position - 1] > temp))
            {
                A[position] = A[position - 1];
                position--;
            }
            A[position] = temp;
        }
        display(A);
    }

    public void bubbleSort(int[] A, int n)
    {
        for(int pass = n-1; pass >= 0; pass--)
        {
            for(int i = 0; i < pass; i++)
            {
                if (A[i] > A[i+1])
                {
                    int temp = A[i];
                    A[i] = A[i + 1];
                    A[i+1] = temp;
                }
            }
        }
        display(A);
    }

    public void display(int[]arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]+"\t");
        }
        Console.WriteLine("\n");
    }

    //Merge Sort
    //Quick Sort

    static void Main(string[] args)
    {
        Program p = new Program();
        int[] arr = new int[10] {67,45,56,12,34,67,87,6,3,12};
        p.selectionSort(arr, arr.Length);
        p.insertionSort(arr,arr.Length);
        p.bubbleSort(arr, arr.Length);
    }
}
