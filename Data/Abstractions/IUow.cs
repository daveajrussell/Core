using System.Threading.Tasks;

namespace Core.Data.Abstractions
{
    public interface IUow
    {
        void Commit();
        Task CommitAsync();
    }
}
