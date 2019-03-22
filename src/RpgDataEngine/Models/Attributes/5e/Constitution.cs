using RpgDataEngine.Models.Attributes;

namespace RpgDataEngine.Models.FifthEdition.Attributes
{
    public class Constitution : IAttribute
    {
        public int BasePoints { get; set; }

        public int Modifier { get; set; }

        public bool HasSavingThrowProficiency { get; set; }
    }
}