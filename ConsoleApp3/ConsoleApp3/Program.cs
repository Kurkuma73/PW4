namespace PW4
{
    class Orc
    {
        private static int totalGold = 0;
        private static int orcCount = 0;
        public int Gold { get; private set; }

        public Orc()
        {
            orcCount++;
            if (orcCount < 5)
            {
                Gold = totalGold;
                totalGold += 2;
            }
            else
            {
                Gold = totalGold - (orcCount - 5) * 2;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                Orc orc = new Orc();
                Console.WriteLine($"Орк {i + 1}, переносит {orc.Gold} золота");
            }

        }
    }
}


