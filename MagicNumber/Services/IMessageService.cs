using System.Threading.Tasks;

namespace MagicNumber.Services
{
    public interface IMessageService
    {
        Task ShowMessageAsync(string message);
    }
}
