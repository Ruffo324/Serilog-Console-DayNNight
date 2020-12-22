using System.Collections.Generic;
using System.Linq;
using Serilog.Sinks.SystemConsole.Themes;

namespace DayNNight.Models
{
	public class DayNNightTheme
	{
		private AnsiConsoleTheme Dark { get; }
		private AnsiConsoleTheme Light { get; }

		public AnsiConsoleTheme Auto =>
			ConsoleAnalyzer.SystemDefault.BackgroundColor.GetBrightness() > 0.5f ? Light : Dark;

		public DayNNightTheme(Dictionary<ConsoleThemeStyle, StyleSet> dark,
			Dictionary<ConsoleThemeStyle, StyleSet> light)
		{
			Dark = new AnsiConsoleTheme(dark.ToDictionary(pair => pair.Key, pair => pair.Value.AnsiEscaped));
			Light = new AnsiConsoleTheme(light.ToDictionary(pair => pair.Key, pair => pair.Value.AnsiEscaped));
		}
	}
}
