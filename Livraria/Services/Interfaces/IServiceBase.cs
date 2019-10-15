namespace Livraria.Services.Interfaces
{
    public interface IServiceBase<TEntity>
    {
        void ValidarEntity(TEntity);
        void ValidarIdEntity(int id);
    }
}
