// See https://aka.ms/new-console-template for more information
class KodePos
{
    private static Dictionary<string, string> tabelKodePos = new Dictionary<string, string>
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };
    public static string getKodePos(string kelurahan)
    {
        if (tabelKodePos.ContainsKey(kelurahan))
        {
            return tabelKodePos[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama kelurahan: ");
        string inputKelurahan = Console.ReadLine();

        string kodePos = KodePos.getKodePos(inputKelurahan);

        Console.WriteLine($"Kode pos untuk {inputKelurahan}: {kodePos}");

        Console.WriteLine("\n====================\n");

        DoorMachine pintu = new DoorMachine();

        pintu.BukaPintu();
        pintu.BukaPintu();
        pintu.KunciPintu();
        pintu.KunciPintu();
    }
}

enum State { Terkunci, Terbuka }
class DoorMachine
{

    private State currentState; 
    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }
    public void KunciPintu()
    {
        if (currentState == State.Terbuka)
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }
    public void BukaPintu()
    {
        if (currentState == State.Terkunci)
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
    }

  
}
