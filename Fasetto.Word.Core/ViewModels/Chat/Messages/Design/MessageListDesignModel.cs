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
            Items = new List<MessageItemViewModel>() {
                new MessageItemDesignModel(),
                new MessageItemDesignModel(),
                new MessageItemDesignModel() };
        }
        
    }
}
