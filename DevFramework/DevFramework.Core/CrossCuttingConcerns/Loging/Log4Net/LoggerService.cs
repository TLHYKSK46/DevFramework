using log4net;
using NHibernate.UserTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.CrossCuttingConcerns.Loging.Log4Net
{
    [Serializable]
    public  class LoggerService
    {
      private  ILog _log;
      
        public LoggerService(ILog log)
        {
            _log = log;
        }
        //metodlar
        public bool IsInfoEnabled => _log.IsInfoEnabled;
        public bool IsDebugEnabled => _log.IsDebugEnabled;
        public bool IsWarnEnabled => _log.IsWarnEnabled;
        public bool IsFatalEnabled => _log.IsFatalEnabled;
        public bool IsErorEnabled => _log.IsErrorEnabled;

        public void Info(Object logMessage) {

            if (IsInfoEnabled)
            {
                _log.Info(logMessage);
            }
        }

        public void Debug(Object logMessage)
        {

            if (IsDebugEnabled)
            {
                _log.Debug(logMessage);
            }

        }

        public void Warn(Object logMessage)
        {

            if (IsWarnEnabled)
            {
                _log.Warn(logMessage);
            }
        }

        public void Fatal(Object logMessage)
        {

            if (IsFatalEnabled)
            {
                _log.Fatal(logMessage);
            }
        }

        public void Eror(Object logMessage)
        {

            if (IsErorEnabled)
            {
                _log.Error(logMessage);
            }
        }

    }
}
