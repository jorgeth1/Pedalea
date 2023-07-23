namespace Pedalea.Infraestructura.Puertos
{
    public interface ILectorArchivosSql
    {
        Task<string> GetQueryFromFile(string path);
    }
}
