using System.Drawing;
using DayNNight.Extensions;

namespace DayNNight.Models
{
	// TODO [C.Groothoff]: Summary.
	public class StyleSet
	{
		public Color? Foreground { get; init; }
		public Color? Background { get; init; }

		public string AnsiEscaped
		{
			get
			{
				var colorStr = Foreground?.ToAnsiForeground() ?? string.Empty;
				colorStr += Background?.ToAnsiBackground() ?? string.Empty;

				if (string.IsNullOrEmpty(colorStr)) return "\x1b[37m"; // Reset.

				return colorStr;
			}
		}
	}
}
