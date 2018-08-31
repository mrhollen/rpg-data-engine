namespace RpgDataEngine.Models.Attributes
{
    public class Intelligence : IAttribute
    {
        public int BasePoints { get; set; }

        public int Modifier { get; set; }

        public bool HasSavingThrowProficiency { get; set; }

        public bool HasArcanaProficiency { get; set; }

        public bool HasHistoryProficiency { get; set; }

        public bool HasInvestigationProficiency { get; set; }

        public bool HasNatureProficiency { get; set; }

        public bool HasReligionProficiency { get; set; }
    }
}