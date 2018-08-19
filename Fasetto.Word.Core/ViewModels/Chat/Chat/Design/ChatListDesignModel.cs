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
            Items = new List<ChatItemViewModel> {
                new ChatItemDesignModel{IsSelected=true },
                new ChatItemDesignModel{NewContentAvailable=true },
                new ChatItemDesignModel(),
                new ChatItemDesignModel(),
                new ChatItemDesignModel(),
                new ChatItemDesignModel(),
                new ChatItemDesignModel(),
                new ChatItemDesignModel(),
                new ChatItemDesignModel(),
                new ChatItemDesignModel(),
                new ChatItemDesignModel(),
                new ChatItemDesignModel(),
            };
        }

    }
}
