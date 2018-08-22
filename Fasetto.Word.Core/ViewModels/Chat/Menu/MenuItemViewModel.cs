using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    public class MenuItemViewModel : ViewModel
    {
        public string Text { get; set; }
        public IconType Icon { get; set; }
        public MenuItemType Type { get; set; }
    }
}