namespace Livraria.Services.Interfaces
{
    public interface IServiceBase<TEntity>
    {
        void ValidarEntity(TEntity entity);
        void ValidarIdEntity(int id);
    }
}
