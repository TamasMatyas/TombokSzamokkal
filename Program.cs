namespace TombokSzamokkal
{
    internal class Program
    {
        static int[] tomb = new int[15];
        static Random r = new Random();
        static void Feltolt()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20, 21);
            }
            foreach (int item in tomb)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


        }
        static void OsszegzesTetel()
        {
            int osszeg = 0;
            foreach (int item in tomb)
            {
                osszeg += item;
            }
            Console.WriteLine($"A számok összege: {osszeg}");

        }
        static void MegszamlalasTetel()
        {
            int db = 0;
            foreach (int item in tomb)
            {
                if (item < 0)
                {
                    db++;
                }
            }
            Console.WriteLine($"Negatív számok a listában: {db}");
        }
        static void EldontesTetel()
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != 0)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van 0 a listában");
            }
            else
            {
                Console.WriteLine("Nincs 0 a listában");
            }
        }
        static void KeresesTetel()
        {
            int keresett = 0;
            int i = 0;
            while (i< tomb.Length && tomb[i] != keresett)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine($"A keresett szám a {i}. helyen van.");
            }
            else
            {
                Console.WriteLine("A keresett szám nicsen a tömben.");
            }
        }
        static void KivalasztasTetel()
        {

        }
        static void Main(string[] args)
        {
            Feltolt();
            //OsszegzesTetel();
            //MegszamlalasTetel();
            //EldontesTetel();
            KeresesTetel();
        }
    }
}
