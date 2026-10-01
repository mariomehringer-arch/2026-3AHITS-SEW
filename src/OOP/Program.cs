// ------------------------------
// OOP
// ------------------------------

using System.Threading.Tasks.Dataflow;

namespace OOP;

class Schule
{

    public string name; //member Variable
    public int anzahl_S;
    public int anzahl_L;
    public int anzahl_G()
    {
        return anzahl_L + anzahl_S;
    }

    //ToString() Methode
    public override string ToString()
    {
        return $"Schule: {name}, Schüler: {anzahl_S} Schüler:{anzahl_L}";
    }

}



class Program
{
    static void Main(string[] args)
    {
        Schule htl = new Schule(); //Object erstellen (instsanzieren )
        htl.anzahl_S = 10;
        htl.anzahl_L = 20;
        htl.name = "HTL Braunau";
        Console.WriteLine($"{htl.anzahl_S}, {htl.name}");


        // HLW
        Schule hlw = new Schule();
        hlw.anzahl_S = 20;
        hlw.name = "HLW Braunau";


        Console.WriteLine($"{hlw.anzahl_S},{hlw.name}");

        Console.WriteLine($"gesammt {htl.anzahl_G()}");



        //-----------------------------------------------------------------------------------

        int n = 42;
        Console.WriteLine(n); //automatischer Aufruf ToString
        Console.WriteLine(htl);
        Console.WriteLine(htl.ToString());
    }
}