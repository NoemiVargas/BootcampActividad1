﻿using JazaniActividad.Domain.Admins.Models;


namespace JazaniActividad.Domain.Cores.Repositories
{
    public interface ICrudRepository<T, ID>
    {
        Task<IReadOnlyList<T>> FindAllAsync();
        Task<T?> FindByIdAsync(ID id);
        Task<T?> SaveAsync(T entity);

    }
}
