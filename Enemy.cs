namespace RPG_Dashboard
{
    internal class Enemy : ICharacter, ICharActions
    {
        #region Propriedades de ICharacter
        public string Name { get; set; } = string.Empty;

        public string CharClass { get; set; } = string.Empty;

        public double MaxHP { get; set; } = 10;

        public double CurrentHP { get; set; }

        public int BaseAttack { get; set; } = 10;

        public int BaseDefense { get; set; } = 10;

        public bool IsAlive { get; set; } = true;
        #endregion

        #region Implementação dos métodos de ICharActions
        public void Attack(ICharacter target)
        {
            Console.WriteLine("--------- Attack ---------");
            Console.WriteLine($"{Name} attacks {target.Name}");

            double damage = BaseAttack - target.BaseDefense;

            if(damage <= 0)
            {
                Console.WriteLine($"{target.Name} has parried {Name}'s attack.");
                return;
            }

            target.CurrentHP = target.CurrentHP - damage;

            Console.WriteLine($"{Name} hits {target.Name} for {damage} points of damage");
            Console.WriteLine($"{target.Name}'s HP: {target.CurrentHP}/{target.MaxHP}");
        }

        public void Heal(int healingAmmount)
        {
            Console.WriteLine("---------  Heal  ---------");
            Console.WriteLine($"{Name} heals.");
            if (CurrentHP + healingAmmount > MaxHP) {
                CurrentHP = MaxHP;
                Console.WriteLine($"{Name} has healed to full health.\n" +
                    $"Current HP: {CurrentHP}/{MaxHP}");
                return;
            }
            CurrentHP = CurrentHP + healingAmmount;
            Console.WriteLine($"{Name} heals {healingAmmount} HP\n" +
                $"Current HP: {CurrentHP}/{MaxHP}");
        }
        #endregion

        internal Enemy(string name,string charClass, double maxHP, int baseAttack,int baseDefense)
        {
            Name = name;
            CharClass = charClass;
            MaxHP = maxHP;
            BaseAttack = baseAttack;
            BaseDefense = baseDefense;
            CurrentHP = MaxHP;
        }
        internal Enemy(string name)
        {
            Name = name;
            CurrentHP = 10;
        }
    }
}
