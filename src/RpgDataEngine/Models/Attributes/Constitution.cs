namespace RpgDataEngine.Models.Attributes
{
    public class Constitution : IAttribute
    {
        public int BasePoints { get; set; }

        public int Modifier { get; set; }

        public bool HasSavingThrowProficiency { get; set; }
    }
}