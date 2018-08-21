using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word
{
    public class ApplicationPageValueConvertor : BaseValueConverter<ApplicationPageValueConvertor>
    {
        public override object Convert(object value, Type targetType = null, object parameter = null, CultureInfo culture = null)
        {
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.LoginPage:
                    return new LoginPage();

                case ApplicationPage.RegisterPage:
                    return new RegisterPage();

                case ApplicationPage.ChatPage:
                    return new ChatPage();


                default:
                    Debugger.Break();
                    return null;

            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
