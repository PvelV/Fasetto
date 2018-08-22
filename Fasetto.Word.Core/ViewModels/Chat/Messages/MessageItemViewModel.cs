using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    public class MessageItemViewModel : ViewModel
    {
        public string SenderName { get; set; }
        public string Message { get; set; }
        public string Initials { get; set; }
        public string ProfilePictureRGB { get; set; }
        public bool IsSelected { get; set; }
        public bool SentByMe { get; set; }
        public bool MessageRead { get { return MessageReadTime > DateTimeOffset.MinValue; } }
        public DateTimeOffset MessageReadTime { get; set; }
        public DateTimeOffset MessageSentTime { get; set; }
        public bool NewItem { get; set; }

        /// <summary>
        /// The attachment to the message, if it is of an image type
        /// </summary>
        public ChatMessageListItemImageAttachmentViewModel ImageAttachment { get; set; }

        /// <summary>
        /// A flag indicating if we have any message text or not
        /// </summary>
        public bool HasMessage => Message != null;

        /// <summary>
        /// A flag indicating if we have an image attached to this message
        /// </summary>
        public bool HasImageAttachment => ImageAttachment != null;
    }
}
