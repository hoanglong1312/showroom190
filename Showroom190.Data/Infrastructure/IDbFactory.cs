using System;

namespace Showroom190.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        Showroom190DbContext Init();
    }
}