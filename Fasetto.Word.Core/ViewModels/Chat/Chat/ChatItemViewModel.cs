using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    public class ChatItemViewModel : ViewModel
    {
        #region Public Properties

        public string Name { get; set; }
        public string Message { get; set; }
        public string Initials { get; set; }
        public string ProfilePictureRGB { get; set; }
        public bool NewContentAvailable { get; set; }
        public bool IsSelected { get; set; }

        #endregion

        #region Commands

        public ICommand OpenMessageCommand { get; }


        #endregion


        public ChatItemViewModel()
        {
            OpenMessageCommand = new Command(OpenMessage);
        }

        private void OpenMessage()
        {
            Container.Application.GoToPage(ApplicationPage.ChatPage, new MessageListDesignModel());
        }
    }
}
