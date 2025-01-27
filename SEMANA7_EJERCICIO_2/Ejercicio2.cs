namespace Torres
{
    class Program
    {
        private const int NumDiscos = 6;

        class Conjunto
        {
            public int[] Discos = new int[NumDiscos];
            public int NumPlatos = 0;
        }

        class Torre
        {
            public Conjunto[] Pilas = new Conjunto[3];
            public int NumPlatos;
        }

        static void TorreInit(Torre T, int num)
        {
            T.NumPlatos = num;
            for (int i = 0; i < 3; i++) T.Pilas[i] = new Conjunto();
            for (int i = num; i > 0; i--) T.Pilas[0].Discos[T.Pilas[0].NumPlatos++] = i;
        }

        static void TorreMoverDisco(Torre T, int Origen, int Destino)
        {
            int disco = T.Pilas[Origen].Discos[--T.Pilas[Origen].NumPlatos];
            T.Pilas[Destino].Discos[T.Pilas[Destino].NumPlatos++] = disco;
            TorreDraw(T);
        }

        static int CalcularAux(int Origen, int Destino)
        {
            if (Origen == 0 && Destino == 1) return 2;
            if (Origen == 0 && Destino == 2) return 1;
            if (Origen == 1 && Destino == 2) return 0;
            if (Origen == 1 && Destino == 0) return 2;
            if (Origen == 2 && Destino == 0) return 1;
            if (Origen == 2 && Destino == 1) return 0;
            return -1;
        }

        static void TorreMoverDisco(Torre T, int Origen, int Destino, int num)
        {
            int aux = CalcularAux(Origen, Destino);
            if (num > 1) TorreMoverDisco(T, Origen, aux, num - 1);
            TorreMoverDisco(T, Origen, Destino);
            if (num > 1) TorreMoverDisco(T, aux, Destino, num -1);
        }

        static void TorreMover(Torre T, int Destino)
        {
            TorreMoverDisco(T, 0, Destino, T.NumPlatos);
        }

        static void TorreDraw(Torre T)
        {
            Console.WriteLine("===============================================================");
            for (int p = 0; p < 3; p++)
            {
                Console.Write(p + ": ");
                for (int i = 0; i < T.Pilas[p].NumPlatos; i++)
                Console.Write(T.Pilas[p].Discos[i] + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Torre T = new Torre();

            TorreDraw(T);

            TorreMover(T, 2);

            Console.WriteLine("Listo");
            Console.ReadKey();
        }
    }
}