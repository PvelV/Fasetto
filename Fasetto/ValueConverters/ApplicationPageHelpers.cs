using Fasetto.Word.Core;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Fasetto.Word
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual view/page
    /// </summary>
    public static class ApplicationPageHelpers
    {
        /// <summary>
        /// Takes a <see cref="ApplicationPage"/> and a view model, if any, and creates the desired page
        /// </summary>
        /// <param name="page"></param>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public static BasePage ToBasePage(this ApplicationPage page, object viewModel = null)
        {
            // Find the appropriate page
            switch (page)
            {
                case ApplicationPage.LoginPage:
                    return new LoginPage(viewModel as LoginPageViewModel);

                case ApplicationPage.RegisterPage:
                    return new RegisterPage(viewModel as RegisterPageViewModel);

                case ApplicationPage.ChatPage:
                    return new ChatPage(viewModel as MessageListViewModel);

                default:
                    Debugger.Break();
                    return null;
            }
        }

        /// <summary>
        /// Converts a <see cref="BasePage"/> to the specific <see cref="ApplicationPage"/> that is for that type of page
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static ApplicationPage ToApplicationPage(this BasePage page)
        {
            // Find application page that matches the base page
            if (page is ChatPage)
                return ApplicationPage.ChatPage;

            if (page is LoginPage)
                return ApplicationPage.LoginPage;

            if (page is RegisterPage)
                return ApplicationPage.RegisterPage;

            // Alert developer of issue
            Debugger.Break();
            return default(ApplicationPage);
        }
    }
}
