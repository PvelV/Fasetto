using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    public class RegisterPageViewModel : ViewModel
    {

        public string Email { get; set; }

        public bool LoginIsRunning { get; set; }

        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }



        public RegisterPageViewModel()
        {
            LoginCommand = new Command(async (param) => await LoginAsync(param));
            RegisterCommand = new Command(async () => await RegisterAsync());
        }



        public async Task LoginAsync(object param)
        {
            await RunCommandAsync(() => LoginIsRunning, async () =>
            {
                await Task.Delay(5000);
                var pass = (param as IHavePassword).SecurePassword.Unsecure();
            });
        }

        public async Task RegisterAsync()
        {
            Container.Get<ApplicationViewModel>().IsSideMenuVisible ^= true;

            Container.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.RegisterPage;
            await Task.Delay(1);
        }
    }
}
