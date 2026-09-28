// ------------------------------
// Ubung_1_1
// ------------------------------

namespace Ubung_1_1;

class Program
{





    static void Main(string[] args)
    {
        int[] arr = { 4, 7, 3, 6, 8, 2 };
        int pos = FindMax(arr);
        Console.WriteLine($"Maximum {pos}");

    }

    static int FindMax(int[] arr)
    {

        int maxPos = 0;
        for (int i = 0; i < 6; i++)
        {


            if (arr[i] > arr[maxPos])
            {
                maxPos = i;
            }

        }
        return maxPos;


    }
}