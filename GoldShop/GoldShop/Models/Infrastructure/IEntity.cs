namespace GoldShop.Models
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
