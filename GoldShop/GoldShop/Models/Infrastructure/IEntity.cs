namespace GoldShop.Models.Infrastructure
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
