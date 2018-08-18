using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    public class ChatListDesignModel : ChatListViewModel
    {

        public static ChatListDesignModel Instance => new ChatListDesignModel();


        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel> {
                new ChatListItemDesignModel{IsSelected=true },
                new ChatListItemDesignModel{NewContentAvailable=true },
                new ChatListItemDesignModel(),
                new ChatListItemDesignModel(),
                new ChatListItemDesignModel(),
                new ChatListItemDesignModel(),
                new ChatListItemDesignModel(),
                new ChatListItemDesignModel(),
                new ChatListItemDesignModel(),
                new ChatListItemDesignModel(),
                new ChatListItemDesignModel(),
                new ChatListItemDesignModel(),
            };
        }

    }
}
