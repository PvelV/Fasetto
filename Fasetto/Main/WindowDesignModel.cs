using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Fasetto.Word
{
    public class WindowDesignModel : WindowViewModel
    {

        public static WindowDesignModel Instance => new WindowDesignModel();

        public ChatListDesignModel ChatListViewModel { get; set; }

        public WindowDesignModel()
        {
            ChatListViewModel = new ChatListDesignModel();
        }

    }
}
