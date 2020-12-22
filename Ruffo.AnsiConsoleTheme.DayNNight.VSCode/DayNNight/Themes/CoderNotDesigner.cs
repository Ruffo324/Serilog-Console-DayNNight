using System.Collections.Generic;
using System.Drawing;
using DayNNight.Extensions;
using DayNNight.Models;
using Serilog.Sinks.SystemConsole.Themes;

namespace DayNNight.Themes
{
	internal class CoderNotDesigner
	{
		private static readonly Color defaultDarkThemeText = Color.FromArgb(0xF1, 0xF2, 0xF1);
		private static readonly Color defaultLightThemeText = Color.FromArgb(39, 39, 39);

		internal static readonly DayNNightTheme Theme = new(
			// Dark part
			new Dictionary<ConsoleThemeStyle, StyleSet>
			{
				[ConsoleThemeStyle.Text] = new() { Foreground = defaultDarkThemeText },
				[ConsoleThemeStyle.SecondaryText] = new() { Foreground = defaultDarkThemeText.ChangeBrightness(-0.2f) },
				[ConsoleThemeStyle.TertiaryText] = new() { Foreground = defaultDarkThemeText.ChangeBrightness(-0.4f) },
				[ConsoleThemeStyle.Invalid] = new() { Foreground = Color.FromArgb(242, 102, 240) },
				[ConsoleThemeStyle.Null] = new() { Foreground = Color.FromArgb(121, 163, 177) },
				[ConsoleThemeStyle.Name] = new() { Foreground = Color.FromArgb(69, 98, 104) },
				[ConsoleThemeStyle.String] = new() { Foreground = Color.FromArgb(242, 180, 41) },
				[ConsoleThemeStyle.Number] = new() { Foreground = Color.FromArgb(65, 154, 242) },
				[ConsoleThemeStyle.Boolean] = new() { Foreground = Color.FromArgb(0xF1, 0xF2, 0xF1) },
				[ConsoleThemeStyle.Scalar] = new() { Foreground = Color.FromArgb(0xF1, 0xF2, 0xF1) },
				[ConsoleThemeStyle.LevelVerbose] = new(),
				[ConsoleThemeStyle.LevelDebug] = new()
				{
					Foreground = Color.FromArgb(36, 60, 113), Background = defaultDarkThemeText.ChangeBrightness(0.2f)
				},
				[ConsoleThemeStyle.LevelInformation] = new()
				{
					Foreground = Color.FromArgb(13, 66, 27), Background = defaultDarkThemeText.ChangeBrightness(0.2f)
				},
				[ConsoleThemeStyle.LevelWarning] = new() { Foreground = Color.FromArgb(242, 158, 34) },
				[ConsoleThemeStyle.LevelError] = new() { Foreground = Color.FromArgb(242, 25, 23) },
				[ConsoleThemeStyle.LevelFatal] = new()
					{ Foreground = defaultDarkThemeText.ChangeBrightness(0.2f), Background = Color.FromArgb(76, 1, 13) }
			},
			// Light part
			new Dictionary<ConsoleThemeStyle, StyleSet>
			{
				[ConsoleThemeStyle.Text] = new() { Foreground = defaultLightThemeText },
				[ConsoleThemeStyle.SecondaryText] = new() { Foreground = defaultLightThemeText.ChangeBrightness(0.2f) },
				[ConsoleThemeStyle.TertiaryText] = new() { Foreground = defaultLightThemeText.ChangeBrightness(0.4f) },
				[ConsoleThemeStyle.Invalid] = new() { Foreground = Color.FromArgb(242, 102, 240) },
				[ConsoleThemeStyle.Null] = new() { Foreground = Color.FromArgb(34, 110, 117) },
				[ConsoleThemeStyle.Name] = new() { Foreground = Color.FromArgb(21, 61, 87) },
				[ConsoleThemeStyle.String] = new() { Foreground = Color.FromArgb(134, 104, 25) },
				[ConsoleThemeStyle.Number] = new() { Foreground = Color.FromArgb(65, 154, 242) },
				[ConsoleThemeStyle.Boolean] = new() { Foreground = Color.FromArgb(40, 116, 192) },
				[ConsoleThemeStyle.Scalar] = new() { Foreground = Color.FromArgb(86, 242, 79) },
				[ConsoleThemeStyle.LevelVerbose] = new(),
				[ConsoleThemeStyle.LevelDebug] = new()
				{
					Foreground = Color.FromArgb(236, 48, 255), Background = defaultLightThemeText.ChangeBrightness(0.2f)
				},
				[ConsoleThemeStyle.LevelInformation] = new()
				{
					Foreground = Color.FromArgb(81, 185, 72), Background = defaultLightThemeText.ChangeBrightness(0.2f)
				},
				[ConsoleThemeStyle.LevelWarning] = new() { Foreground = Color.FromArgb(242, 158, 34) },
				[ConsoleThemeStyle.LevelError] = new() { Foreground = Color.FromArgb(242, 25, 23) },
				[ConsoleThemeStyle.LevelFatal] = new()
				{
					Foreground = defaultLightThemeText.ChangeBrightness(0.2f), Background = Color.FromArgb(234, 81, 84)
				}
			}
		);
	}
}
