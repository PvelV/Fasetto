using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    public class ChatItemDesignModel : ChatItemViewModel
    {

        public static ChatItemDesignModel Instance => new ChatItemDesignModel();


        public ChatItemDesignModel()
        {
            Name = "Test Name";
            Message = "Test Message";
            Initials = "LM";
            ProfilePictureRGB = "0000FF";
        }

    }
}
