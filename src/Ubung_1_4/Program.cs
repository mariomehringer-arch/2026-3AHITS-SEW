// ------------------------------
// Ubung_1_4
// ------------------------------

using System.Threading.Tasks.Dataflow;

namespace Ubung_1_4;

class Program
{
    static void Main(string[] args)
    {

        int f = 1;
        int[] arr=new int [12];


        for (int i = 1; i < 12; i++)
        {
            f = f * i;
            arr[i-1] = f;
        }
        for (int i = 11; i >=0; i--)
        {

            Console.WriteLine(arr[i]);
        }



    }
}
