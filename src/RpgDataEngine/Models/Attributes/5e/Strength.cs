using RpgDataEngine.Models.Attributes;

namespace RpgDataEngine.Models.FifthEdition.Attributes
{
    public class Strength : IAttribute
    {
        public int BasePoints { get; set; }

        public int Modifier { get; set; }

        public bool HasSavingThrowProficiency { get; set; }

        public bool HasAthleticsProficiency { get; set; }
    }
}