namespace RPG_Dashboard
{
    internal interface ILevel
    {
        int Experience { get; set; }

        int ExperienceToNextLevel { get; set; }

        int Level { get; set; }

        public void LevelUpCharacter();
    }
}
