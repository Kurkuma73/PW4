namespace PW4
{
    class Package
    {
        public string Description { get; set; }
        public int Weight { get; set; }
        public Package(string description, int weight)
        {
            Weight = weight;
            Description = description;
        }
    }
    class Sending
    {
        public int WeightLimit { get; set; }
        private int TotalWeight { get; set; }

        public Sending(int weightLimit)
        {
            WeightLimit = weightLimit;
            TotalWeight = 0;
        }
        public void SendPackage(Package package)
        {
            if (TotalWeight + package.Weight > WeightLimit)
            {
                Console.WriteLine($"Ваша посылка отменена. Нельзя отправить посылку, которая превышает максимальный вес. Максимальный вес: {WeightLimit}, вес посылки: {package.Weight}");
                return;
            }
            TotalWeight += package.Weight;
            Console.WriteLine($"Ваша посылка отправлена. Вес: {package.Weight}, посылка: {package.Description}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sending myMailService = new Sending(3000);
            Package package01 = new Package("Альбом Stray Kids", 300);
            myMailService.SendPackage(package01);
            Package package02 = new Package("Велосипед", 4000);
            myMailService.SendPackage(package02);
            Console.ReadKey(true);
        }
    }
}
