using Pedalea.Infraestructura.Puertos;

namespace Pedalea.Infraestructura.Adaptadores.Repositorios
{
    internal class LectorArchivosSql : ILectorArchivosSql
    {
        public async Task<string> GetQueryFromFile(string path)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
            string fileContent = await File.ReadAllTextAsync(filePath);
            return fileContent;
        }
    }
}
