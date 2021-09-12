using System.Threading.Tasks;

namespace SystematicQ.Brokers.Common.Interfaces
{
    /// <summary>
    /// interface broker [factory: product]
    /// </summary>
    public interface IBroker
    {
        Task AuthenticateAsync();        
    }
}
