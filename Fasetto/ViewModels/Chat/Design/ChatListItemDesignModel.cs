using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word
{
    public class ChatListItemDesignModel : ChatListItemViewModel
    {

        public static ChatListItemDesignModel Instance => new ChatListItemDesignModel();


        public ChatListItemDesignModel()
        {
            Name = "Test Name";
            Message = "Test Message";
            Initials = "LM";
            ProfilePictureRGB = "0000FF";
        }

    }
}
