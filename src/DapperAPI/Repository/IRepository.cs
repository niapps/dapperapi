using DapperAPI.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DapperAPI.Repository
{
    public interface IRepository<T>
    {
        IDbConnection Connection { get; }

        void Add(T prod);

        IEnumerable<T> GetAll();

        T GetByID(int id);

        void Delete(int id);
        void Update(T prod);
    }
}
