using Livraria.Services.Interfaces;
using System;

namespace Livraria.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity>
    {
        public void ValidarEntity(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));         
        }

        public void ValidarIdEntity(int id)
        {
            if (id == 0)
                throw new ArgumentException("O id informado é inválido.");
        }
    }
}
