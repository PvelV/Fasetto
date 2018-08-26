using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word
{
    public  class ViewModelLocator
    {
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

        public static ApplicationViewModel ApplicationViewModel
        { get
            {
                var a = Container.Application;
                return a;
            } }
        public static SettingsViewModel SettingsViewModel => Container.Settings;

    }
}
