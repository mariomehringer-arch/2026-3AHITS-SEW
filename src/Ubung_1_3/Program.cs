// ------------------------------
// Ubung_1_3
// ------------------------------

using System.Reflection.Metadata.Ecma335;

namespace Ubung_1_3;

class Program
{
    static void Main(string[] args)
    {
        string[] namen = { "Mayer", "Huber", "Gruber" };
        int[] punkte = { 21, 18, 15 };

        getNote(punkte, namen);




    }
    static void getNote(int[] punkte, string[] namen)
    {
        for (int i = 0; i < 3; i++)
        {
            if (punkte[i] >= 21)
            {

                Console.WriteLine($"{namen[i]} Sehrgut");
            }
            if (punkte[i] >= 18 && punkte[i] < 21)
            {

                Console.WriteLine($"{namen[i]} Gut");
            }
            if (punkte[i] >= 15 && punkte[i] < 18)
            {

                Console.WriteLine($"{namen[i]} Befriedigend");
            }
            if (punkte[i] >= 12 && punkte[i] < 15)
            {
                Console.WriteLine($"{namen[i]} Genügend");
            }

        }
    }



}

