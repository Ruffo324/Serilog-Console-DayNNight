using Serilog.Sinks.SystemConsole.Themes;

namespace DayNNight
{
	public static class Theme
	{
		public static AnsiConsoleTheme CoderNotDesigner { get; } = Themes.CoderNotDesigner.Theme.Auto;
	}
}
