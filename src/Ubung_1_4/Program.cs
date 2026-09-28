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

        for (int i = 1; i < 25; i++)
        {
            f = f * i;

        }
        Console.WriteLine(f);


    }
}
