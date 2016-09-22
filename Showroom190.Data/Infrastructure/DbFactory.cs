using System;

namespace Showroom190.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private Showroom190DbContext dbContext;

        public Showroom190DbContext Init()
        {
            return dbContext ?? (dbContext = new Showroom190DbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}