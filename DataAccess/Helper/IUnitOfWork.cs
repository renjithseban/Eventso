using System;

namespace DataAccess.Helper
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
