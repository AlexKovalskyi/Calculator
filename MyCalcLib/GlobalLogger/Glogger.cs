using NLog;

namespace GlobalLogger
{
    public static class GLogger
    {
		private static Logger logger;

		public static Logger Logger
		{
			get
			{
				return logger = logger ?? LogManager.GetCurrentClassLogger();
			}
		}
		public static int RunAmount { get; set; } = 0;
	}
}
