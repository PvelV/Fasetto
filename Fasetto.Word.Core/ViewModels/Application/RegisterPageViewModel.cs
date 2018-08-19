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
            LoginCommand = new Command(async () => await LoginAsync());
            RegisterCommand = new Command(async (param) => await RegisterAsync(param));
        }



        public async Task LoginAsync()
        {
            await RunCommandAsync(() => LoginIsRunning, async () =>
            {
                //   var pass = (param as IHavePassword).SecurePassword.Unsecure();
                Container.Get<ApplicationViewModel>().GoToPage(ApplicationPage.LoginPage);
                Container.Get<ApplicationViewModel>().IsSideMenuVisible = false;

            });
        }

        public async Task RegisterAsync(object param)
        {
            await Task.Delay(1000);
            Container.Get<ApplicationViewModel>().IsSideMenuVisible = true;

            Container.Get<ApplicationViewModel>().GoToPage(ApplicationPage.ChatPage);
        }
    }
}
