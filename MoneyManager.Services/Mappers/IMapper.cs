using MoneyManager.Db.Entity;
using MoneyManager.Services.Dto;

namespace MoneyManager.Services.Mappers
{
    public interface IMapper<TDto, TEntity> where TEntity : IEntity where TDto : IDto
    {
        TDto ToDto(TEntity entity);
        TEntity ToEntity(TDto dto);
    }
}