using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Aplication.Interfaces.Repositories;
using YoutubeApi.Aplication.Interfaces.Repositories.UnitOfWorks;
using YoutubeApi.Persistence.Context;
using YoutubeApi.Persistence.Repositories;


namespace YoutubeApi.Persistence.UnitOfWorks
{
    public class UnitofWork : IUnitOfWork
    {

        public readonly AppDbContext dbContext;

        public UnitofWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async ValueTask DisposeAsync() =>await dbContext.DisposeAsync();


        public int Save() => dbContext.SaveChanges();
        
        public async Task<int> SaveAsync()=>await dbContext.SaveChangesAsync();
        

        IReadRepository<T> IUnitOfWork.GetReadRepository<T>()=>new ReadRepository<T>(dbContext);

        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>()=>new WriteRepository<T>(dbContext);
    }
}
