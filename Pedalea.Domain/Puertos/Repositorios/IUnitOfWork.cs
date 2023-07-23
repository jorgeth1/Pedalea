namespace Pedalea.Dominio.Puertos.Repositorios
{
    public interface IUnitOfWork : IDisposable
    {
        Task SaveChangesAsync(CancellationToken cancellationToken);
    }
}
