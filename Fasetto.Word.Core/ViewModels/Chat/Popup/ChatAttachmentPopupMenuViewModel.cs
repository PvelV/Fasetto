using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    public class ChatAttachmentPopupMenuViewModel : BasePopupViewModel
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatAttachmentPopupMenuViewModel()
        {
            Content = new MenuViewModel
            {
                Items = new List<MenuItemViewModel>(new[]
                {
                    new MenuItemViewModel { Text = "Attach a file...", Type = MenuItemType.Header },
                    new MenuItemViewModel { Text = "From Computer", Icon = IconType.File },
                    new MenuItemViewModel { Text = "From Pictures", Icon = IconType.Picture },
                })
            };
        }

        #endregion
    }

}
