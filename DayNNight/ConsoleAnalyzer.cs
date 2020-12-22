using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;

namespace DayNNight
{
	// TODO [C.Groothoff]: Summary.
	public static class ConsoleAnalyzer
	{
		public static class SystemDefault
		{
			public static Color ForegroundColor { get; } = GetDefaultColor(10, Color.White);

			public static Color BackgroundColor { get; } = GetDefaultColor(11, Color.Black);
			public static bool IsDarkMode => BackgroundColor.GetBrightness() < 0.5f;
		}

		private static Color GetDefaultColor(int ansiTypeCode, Color fallback)
		{
			if (!TryEvaluateProcess("printf", $"\033]{ansiTypeCode};?\007", out var xtermResult) ||
				!xtermResult.Contains("rgb"))
				return fallback; // Default fallback background.

			var rgb = xtermResult[xtermResult.IndexOf(':')..].Split("/");
			var red = int.Parse(rgb[0], NumberStyles.HexNumber);
			var green = int.Parse(rgb[1], NumberStyles.HexNumber);
			var blue = int.Parse(rgb[2], NumberStyles.HexNumber);
			return Color.FromArgb(red, green, blue);
		}

		private static bool TryEvaluateProcess(string command, string arguments, out string result)
		{
			try
			{
				var processInfo = new ProcessStartInfo(command, arguments)
					{ UseShellExecute = false, RedirectStandardOutput = true };

				using var process = Process.Start(processInfo);
				if (process == null)
					throw new InvalidOperationException("Could start process 'git!'");

				result = process.StandardOutput.ReadToEnd();
				//.Replace("\n", string.Empty).Replace("\r", string.Empty);
				return true;
			}
			catch (Exception)
			{
				// TODO [C.Groothoff]: Handle correct...
				result = string.Empty;
				return false;
			}
		}
	}
}
