namespace RpgDataEngine.Models.Objects.Weapons
{
    public interface IWeapon : IObject
    {
        int Damage { get; set; }
    }
}