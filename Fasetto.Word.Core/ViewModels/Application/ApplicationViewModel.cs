﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    public class ApplicationViewModel : ViewModel
    {
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.ChatPage;

        public bool IsSideMenuVisible { get; set; } = true;

        internal void GoToPage(ApplicationPage chatPage)
        {
            CurrentPage = chatPage;
        }
    }
}
