using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeAlert.Data
{
    public interface IBaseRepository<T> : IDisposable where T : TableData, new()
    {
        // Create or update
        void SaveEntityWithChildren(T entity, bool recursive = false);

        // Read entity
        T? GetEntity(int id);

        // Read list of entities
        List<T>? GetEntitiesWithChildren();

        // Delete entities
        void DeleteEntitiesWithChildren(T entity);
    }
}
