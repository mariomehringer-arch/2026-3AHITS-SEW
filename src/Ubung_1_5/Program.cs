// ------------------------------
// Ubung_1_5
// ------------------------------

namespace Ubung_1_5;

class Program
{
    static void Main(string[] args)
    {

        bool a;
        int x = 1003;

        Console.WriteLine(isPrim(x));

    }

    static int isPrim(int x)
    {

        //if (x % 2 != 0 && x % 3 != 0 && x % 5 != 0 && x % 7 != 0 && x != 3 && x != 5 && x != 7)
        for (int i = 0; x > i; i++)

            for (int j = 0; j < i; j++)
            {
                if (i + 1 = x)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }


    }


}
