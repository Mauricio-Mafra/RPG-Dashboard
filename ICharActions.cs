namespace RPG_Dashboard
{
    internal interface ICharActions
    {
        public void Attack(ICharacter target);

        public void Heal(int healingAmount);

    }
}
