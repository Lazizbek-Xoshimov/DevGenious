﻿namespace DevGenious.Data.IRepositories;

public interface IRepository <TEntity>
{
    public Task<TEntity> InsertAsync (TEntity entity);
    public Task<TEntity> UpdateAsync (TEntity entity);
    public Task<bool> DeleteAsync(long id);
    public Task<TEntity> SelectByIdAsync(long id);
    public Task<IEnumerable<TEntity>> SelectAllAsync();
}
