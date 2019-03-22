namespace RpgDataEngine.Models.FifthEdition.Entities 
{
    using System;
    using System.Collections.Generic;
    using RpgDataEngine.Models.Attributes;
    using RpgDataEngine.Models.Entities;
    using RpgDataEngine.Models.FifthEdition.Attributes;

    public class Character : ICharacter
    {
        public bool IsPlayer { get; set; }

        public string Name { get; set; }

        public int MaxHitPoints { get; set; }

        public int CurrentHitPoints { get; set; }

        public int Initiation { get; set; }

        public int InspirationPoints { get; set; }

        public int ProficiencyBonus { get; set; }

        public IDictionary<int, int> SpellSlots { get; set; }

        public IDictionary<int, int> SpellSlotsAvailable { get; set; }

        public IEnumerable<IAttribute> Attributes { get; set; }
    }
}