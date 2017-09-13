using log4net;

namespace DomainTest.Utilities
{
    public class Log4NetWrapper
    {
        public Log4NetWrapper()
        {
            Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
        public ILog Log { get; set; }
        public static Log4NetWrapper getInstance()

        {
            return new Log4NetWrapper();
        }
    }
}
