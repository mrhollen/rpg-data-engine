namespace RpgDataEngine.Models.Attributes
{
    public class Dexterity : IAttribute
    {
        public int BasePoints { get; set; }

        public int Modifier { get; set; }

        public bool HasSavingThrowProficiency { get; set; }

        public bool HasAcrobaticsProficiency { get; set; }

        public bool HasSleightOfHandProficiency { get; set; }

        public bool HasStealthProficiency { get; set; }
    }
}