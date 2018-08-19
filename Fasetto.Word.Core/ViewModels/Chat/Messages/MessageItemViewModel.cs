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
        public bool NewContentAvailable { get; set; }
        public bool IsSelected { get; set; }
        public bool SentByMe { get; set; }
        public bool MessageRead { get { return MessageReadTime > DateTimeOffset.MinValue; } }
        public DateTimeOffset MessageReadTime { get; set; }
        public DateTimeOffset MessageSentTime { get; set; }
       
    }
}
