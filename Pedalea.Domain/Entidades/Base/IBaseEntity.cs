namespace Pedalea.Dominio.Entidades.Base
{
    public interface IBaseEntity<TId>
    {
        public TId Id { get; set; }
    }
}
