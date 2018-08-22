using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    public class MessageListDesignModel : MessageListViewModel
    {
        public static MessageListDesignModel Instance => new MessageListDesignModel();


        public MessageListDesignModel()
        {
            Items = new System.Collections.ObjectModel.ObservableCollection<MessageItemViewModel>() {
                new MessageItemDesignModel{ SentByMe = false},
                new MessageItemDesignModel{MessageReadTime=DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.2))},
                new MessageItemDesignModel() };
        }
        
    }
}
