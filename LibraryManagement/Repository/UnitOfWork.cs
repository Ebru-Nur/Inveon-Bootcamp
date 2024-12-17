using LibraryManagement.Data;
using LibraryManagement.Interfaces;

namespace LibraryManagement.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AppDbContext context;
        private IBookRepository bookRepository;

        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
        }

        public IBookRepository Books => this.bookRepository ??= new BookRepository(context);

        public async Task<int> CommitAsync()
        {
            return await this.context.SaveChangesAsync();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
