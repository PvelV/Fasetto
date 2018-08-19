using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    public class LoginPageViewModel : ViewModel
    {

        public string Email { get; set; }

        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }

        public bool LoginIsRunning { get; set; }


        public LoginPageViewModel()
        {
            LoginCommand = new Command(async (param) => await LoginAsync(param));
            RegisterCommand = new Command(async () => await RegisterAsync());
        }

        public async Task LoginAsync(object param)
        {
            await RunCommandAsync(() => LoginIsRunning, async () =>
            {
                await Task.Delay(1000);

                Container.Get<ApplicationViewModel>().IsSideMenuVisible = true;

                //   var pass = (param as IHavePassword).SecurePassword.Unsecure();

                Container.Get<ApplicationViewModel>().GoToPage(ApplicationPage.ChatPage);
            });
        }

        public async Task RegisterAsync()
        {
            Container.Get<ApplicationViewModel>().IsSideMenuVisible = false;

            Container.Get<ApplicationViewModel>().GoToPage(ApplicationPage.RegisterPage);
        }
    }
}
