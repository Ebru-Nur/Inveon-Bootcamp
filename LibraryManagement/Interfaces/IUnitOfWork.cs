namespace LibraryManagement.Interfaces
{
    public interface IUnitOfWork
    {
        IBookRepository Books { get; }
        Task<int> CommitAsync();
    }
}
