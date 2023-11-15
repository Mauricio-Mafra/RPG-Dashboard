namespace RPG_Dashboard
{
    internal interface ICharacter
    {
        public string Name { get; set; }
        public string CharClass { get; set; }
        public double MaxHP { get; set; }

        public double CurrentHP { get; set; }

        public int BaseAttack { get; set; }

        public int BaseDefense { get; set; }


        public bool IsAlive { get; set; }
    }
}
