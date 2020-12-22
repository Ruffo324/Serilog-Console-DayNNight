using System;
using System.Threading;
using Serilog;

namespace DayNNight
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Log.Logger = new LoggerConfiguration()
				.MinimumLevel.Verbose()
				.WriteTo.Console(theme: Theme.CoderNotDesigner)
				.CreateLogger();

			Log.Information("Hello, world!");
			Log.Warning("Is \"DarkMode\" enabled? My code say's: {Is}", ConsoleAnalyzer.SystemDefault.IsDarkMode);
			Console.ResetColor();
			Log.Verbose("Console.Background is: {0}", Console.BackgroundColor);
			Log.Verbose("Console.Foreground is: {0}", Console.ForegroundColor);

			try
			{
				Log.Debug("Getting started");

				Log.Information("Hello {Name} from thread {ThreadId}", Environment.GetEnvironmentVariable("USERNAME"),
					Thread.CurrentThread.ManagedThreadId);

				Log.Warning("No coins remain at position {@Position}", new { Lat = 25, Long = 134 });
				Log.Warning("No coins remain at position {@Position}", new { Lat = 25, Long = 134 });

				Fail();
			}
			catch (Exception e)
			{
				Log.Debug(e, "Debugging? '{0}'", true);
				Log.Warning(e, "Nahh, just a warning.....");
				Log.Error(e, "Something went wrong");
				Log.Fatal(e, "Something went horribly wrong! '{0}'", "DATA_SECURITY_STUFF");
			}

			Log.CloseAndFlush();
		}

		private static void Fail()
		{
			throw new DivideByZeroException();
		}
	}
}
