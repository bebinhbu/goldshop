namespace GoldShop.Models.Infrastructure
{
    public interface IBaseEntity
    {
        bool Deleted { get; set; }
        bool Active { get; set; }
    }
}
