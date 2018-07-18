using Fiddler;
using log4net;
using System;

namespace FiddlerLogger
{
	public class Logger : IAutoTamper
	{
		private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public void AutoTamperRequestAfter(Session oSession)
		{
		}

		public void AutoTamperRequestBefore(Session oSession)
		{
		}

		public void AutoTamperResponseAfter(Session oSession)
		{
		}

		public void AutoTamperResponseBefore(Session oSession)
		{
			log.Info($"{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.fff")}," +
				$"{oSession.id}," +
				$"{oSession.hostname}," +
				$"{oSession.m_hostIP}," +
				$"{oSession.fullUrl}," +
				$"{oSession.responseCode}," +
				$"{oSession.Timers.ClientConnected.ToString("HH:mm:ss.fff")}," +
				$"{oSession.Timers.ClientBeginRequest.ToString("HH:mm:ss.fff")}," +
				$"{oSession.Timers.ClientDoneRequest.ToString("HH:mm:ss.fff")}," +
				$"{oSession.Timers.ClientBeginResponse.ToString("HH:mm:ss.fff")}," +
				$"{oSession.Timers.ClientDoneResponse.ToString("HH:mm:ss.fff")}," +
				$"{oSession.Timers.ServerConnected.ToString("HH:mm:ss.fff")}," +
				$"{oSession.Timers.ServerBeginResponse.ToString("HH:mm:ss.fff")}," +
				$"{oSession.Timers.ServerDoneResponse.ToString("HH:mm:ss.fff")}");
		}

		public void OnBeforeReturningError(Session oSession)
		{
			log.Error($"{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.fff")}," +
				$"{oSession.id}," +
				$"{oSession.hostname}," +
				$"{oSession.m_hostIP}," +
				$"{oSession.fullUrl}," +
				$"{oSession.responseCode}," +
				$"{oSession.Timers.ClientConnected.ToString("HH:mm:ss.fff")}," +
				$"{oSession.Timers.ClientBeginRequest.ToString("HH:mm:ss.fff")}," +
				$"{oSession.Timers.ClientDoneRequest.ToString("HH:mm:ss.fff")}," +
				$"{oSession.Timers.ClientBeginResponse.ToString("HH:mm:ss.fff")}," +
				$"{oSession.Timers.ClientDoneResponse.ToString("HH:mm:ss.fff")}," +
				$"{oSession.Timers.ServerConnected.ToString("HH:mm:ss.fff")}," +
				$"{oSession.Timers.ServerBeginResponse.ToString("HH:mm:ss.fff")}," +
				$"{oSession.Timers.ServerDoneResponse.ToString("HH:mm:ss.fff")}");
		}

		public void OnBeforeUnload()
		{
		}

		public void OnLoad()
		{
			log.Error("TimeStamp,Id,HostName,HostIP,FullURL,ResponseCode,ClientConnected,ClientBeginRequest,ClientDoneRequest,ClientBeginResponse,ClientDoneResponse,ServerConnected,ServerBeginResponse,ServerDoneResponse");
			if (log.IsInfoEnabled) FiddlerApplication.AlertUser("AVLogger", "Logging is enabled");
		}
	}
}