namespace RpgDataEngine.Models.Objects.Weapons
{
    public class Sword : IWeapon
    {
        public string Name { get; set; } = "Un-named Sword";

        public string Description { get; set; }

        public double Weight { get; set; }

        public double Value { get; set; }

        public bool IsMagicalFocus { get; set; }
        
        public int Damage { get; set; }
    }
}