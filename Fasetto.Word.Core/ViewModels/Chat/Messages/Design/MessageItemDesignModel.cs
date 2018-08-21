using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    public class MessageItemDesignModel : MessageItemViewModel
    {

        public static MessageItemDesignModel Instance => new MessageItemDesignModel();


        public MessageItemDesignModel()
        {
            SenderName = "Test Name";
            Message = "Test Message";
            Initials = "LM";
            ProfilePictureRGB = "0000FF";
            SentByMe = true;
            MessageSentTime = DateTimeOffset.UtcNow;
        }

    }
}
