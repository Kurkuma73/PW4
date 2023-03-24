namespace PW4
{

    class Spell
    {
        public int Mana { get; private set; }
        public string Effect { get; set; }
        public string Name { get; set; }
        public Spell(string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }
        public void Use(Magician magician)
        {
            Console.WriteLine($"{magician.Name} колдует! {Effect}");
        }
    }

    class Magician
    {
        public string Name { get; private set; }
        public int Mana { get; private set; }
        public Magician(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }
        public void CastSpell(Spell spell)
        {
            if (Mana >= spell.Mana)
            {
                spell.Use(this);
                Mana -= spell.Mana;
            }
            else
            {
                Console.WriteLine($"Для использования {spell.Name} не хватает {spell.Mana - Mana} единиц маны. Хлебните зелья!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Spell alohomora = new Spell("Алохомора", 50, "Замок открывается!");
            Spell vingardiumLeviosa = new Spell("Вингардиум Левиоса", 20, "Предмет поднимается в воздух!");
            Magician garryPotter = new Magician("Гарри Поттер", 150);

            garryPotter.CastSpell(alohomora);
            garryPotter.CastSpell(vingardiumLeviosa);
        }
    }
}
