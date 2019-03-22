namespace RpgDataEngine.Models.Objects.Weapons
{
    public class Sword : IWeapon
    {
        public string Name { get; set; } = "Unnamed Sword";

        public string Description { get; set; }

        public double Weight { get; set; }

        public double Value { get; set; }

        public bool Enchanted { get; set; } = false;
        
        public int Damage { get; set; }
    }
}