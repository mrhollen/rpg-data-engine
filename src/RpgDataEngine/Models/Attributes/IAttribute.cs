namespace RpgDataEngine.Models.Attributes
{
    public interface IAttribute
    {
        int BasePoints { get; set; }

        int Modifier { get; set; }

        bool HasSavingThrowProficiency { get; set; }
    }
}