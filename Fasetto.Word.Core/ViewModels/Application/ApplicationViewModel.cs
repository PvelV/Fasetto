using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    public class ApplicationViewModel : ViewModel
    {
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.LoginPage;

    }
}
