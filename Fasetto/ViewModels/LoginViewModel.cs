using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word
{
    public class LoginViewModel : ViewModel
    {

        public string Email { get; set; }

        public Command LoginCommand { get; set; }

        public bool LoginIsRunning { get; set; }


        public LoginViewModel()
        {
            LoginCommand = new Command(async (param) => await Login(param));
        }

        private async Task Login(object param)
        {
            await RunCommandAsync(() => LoginIsRunning, async () =>
            {
                await Task.Delay(5000);
                var pass = (param as IHavePassword).SecurePassword.Unsecure();
            });
        }
    }
}
