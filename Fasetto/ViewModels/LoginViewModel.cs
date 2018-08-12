using Fasetto.Common;
using Fasetto.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.ViewModels
{
    public class LoginViewModel : ViewModel
    {

        public string Email { get; set; }

        public Command LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(async (param) => await Login(param));
        }

        private async Task Login(object param)
        {
            await Task.Delay(5000);
            var pass = (param as IHavePassword).SecurePassword.Unsecure();
        }
    }
}
