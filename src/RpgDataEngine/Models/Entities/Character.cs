namespace RpgDataEngine.Models.Entities 
{
    using System;
    using RpgDataEngine.Models.Attributes;

    public class Character
    {
        public bool IsPlayer { get; set; }

        public string Name { get; set; }

        public int MaxHitPoints { get; set; }

        public int CurrentHitPoints { get; set; }

        public int Initiation { get; set; }

        public int InspirationPoints { get; set; }

        public int ProficiencyBonus { get; set; }

        public Strength Strength { get; set; }

        public Dexterity Dexterity { get; set; }

        public Constitution Constitution { get; set; }

        public Intelligence Intelligence { get; set; }

        public Wisdom Wisdom { get; set; }

        public Charisma Charisma { get; set; }
    }
}