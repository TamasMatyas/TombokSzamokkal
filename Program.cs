namespace TombokSzamokkal
{
    internal class Program
    {
        static int[] tomb = new int[15];
        static Random r = new Random();
        static void Feltolt()
        {
            for (int  i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20,21);
            }
            foreach (int item in tomb)
            {
                Console.Write(item+ " ");
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
        //static void 
        static void Main(string[] args)
        {
            Feltolt();
            //OsszegzesTetel();
            //MegszamlalasTetel();
        }
    }
}
