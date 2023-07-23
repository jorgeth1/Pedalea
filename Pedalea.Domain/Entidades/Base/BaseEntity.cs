namespace Pedalea.Dominio.Entidades.Base
{
    public class BaseEntity<TId> : DomainEntity, IBaseEntity<TId>
    {
        public TId Id { get; set; }
    }
}
