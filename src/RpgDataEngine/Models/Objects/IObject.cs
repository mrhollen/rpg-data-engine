namespace RpgDataEngine.Models.Objects
{
    public interface IObject
    {
        string Name { get; set; }

        string Description { get; set; }

        double Weight { get; set; }

        double Value { get; set; }

        bool Enchanted { get; set; }
    }
}