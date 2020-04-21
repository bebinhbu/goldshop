using System;

namespace GoldShop.Models
{
    public abstract class BaseEntity
    {
        public DateTime? DeletedAt { get; private set; }
        public void MakeAsDelete() => DeletedAt = DateTime.UtcNow;
        public bool Active { get; set; }
    }
}
