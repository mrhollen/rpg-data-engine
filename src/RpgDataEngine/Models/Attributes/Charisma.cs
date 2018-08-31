namespace RpgDataEngine.Models.Attributes
{
    public class Charisma : IAttribute
    {
        public int BasePoints { get; set; }

        public int Modifier { get; set; }

        public bool HasSavingThrowProficiency { get; set; }

        public bool HasDeceptionProficiency { get; set; }

        public bool HasIntimidationProficiency { get; set; }

        public bool HasPerformanceProficiency { get; set; }

        public bool HasPersuasionProficiency { get; set; }
    }
}