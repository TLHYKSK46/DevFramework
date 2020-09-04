using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.CrossCuttingConcerns.Loging.Log4Net
{
    [Serializable]
   public class SerializableLogEvent
    {
        private LoggingEvent _logingEvent;

        public SerializableLogEvent(LoggingEvent logingEvent)
        {
            _logingEvent = logingEvent;
        }
        //methodlar
        public string UserName => _logingEvent.UserName;
        public object MessageObject => _logingEvent.MessageObject;
    }
}
