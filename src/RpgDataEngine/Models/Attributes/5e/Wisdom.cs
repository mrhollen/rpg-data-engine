using RpgDataEngine.Models.Attributes;

namespace RpgDataEngine.Models.FifthEdition.Attributes
{
    public class Wisdom : IAttribute
    {
        public int BasePoints { get; set; }

        public int Modifier { get; set; }

        public bool HasSavingThrowProficiency { get; set; }

        public bool HasAnimalHandlingProficiency { get; set; }

        public bool HasInsightProficiency { get; set; }

        public bool HasMedicineProficiency { get; set; }

        public bool HasPerceptionProficiency { get; set; }

        public bool HasSurvivalProficiency { get; set; }
    }
}