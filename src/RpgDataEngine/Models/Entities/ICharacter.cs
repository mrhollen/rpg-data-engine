using System.Collections.Generic;
using RpgDataEngine.Models.Attributes;

namespace RpgDataEngine.Models.Entities
{
    public interface ICharacter
    {
        bool IsPlayer { get; set; }

        string Name { get; set; }

        int MaxHitPoints { get; set; }

        int CurrentHitPoints { get; set; }

        int Initiation { get; set; }

        IEnumerable<IAttribute> Attributes { get; set; }
    }
}