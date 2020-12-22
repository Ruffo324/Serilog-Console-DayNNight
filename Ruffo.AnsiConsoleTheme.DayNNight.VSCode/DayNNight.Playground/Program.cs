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
			Console.ResetColor();
			Log.Verbose("Console.Background is: {0}", Console.BackgroundColor);
			Log.Verbose("Console.Foreground is: {0}", Console.ForegroundColor);

			try
			{
				Log.Debug("Getting started");

				Log.Information("Hello {Name} from thread {ThreadId}", Environment.GetEnvironmentVariable("USERNAME"),
					Thread.CurrentThread.ManagedThreadId);

				Log.Warning("No coins remain at position {@Position}", new { Lat = 25, Long = 134 });

				Fail();
			}
			catch (Exception e)
			{
				Log.Error(e, "Something went wrong");
			}

			Log.CloseAndFlush();
		}

		private static void Fail()
		{
			throw new DivideByZeroException();
		}
	}
}
