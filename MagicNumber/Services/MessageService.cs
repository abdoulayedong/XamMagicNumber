using System.Threading.Tasks;

namespace MagicNumber.Services
{
    public class MessageService : IMessageService
    {
        public async Task ShowMessageAsync(string message)
        {
            await App.Current.MainPage.DisplayAlert("Mmmmmm", message, "Ok");
        }
    }
}
