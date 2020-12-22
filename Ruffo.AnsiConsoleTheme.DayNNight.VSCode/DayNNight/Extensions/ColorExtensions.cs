using System.Drawing;

namespace DayNNight.Extensions
{
	public static class ColorExtensions
	{
		private const string _ansiColorTemplate = "\u001b[{0};2;{1};{2};{3}m"; // \x1b

		public static string ToAnsiForeground(this Color color)
		{
			const int type = 38; // foreground
			return string.Format(_ansiColorTemplate, type, color.R, color.G, color.B);
		}

		public static string ToAnsiBackground(this Color color)
		{
			const int type = 48; // background
			return string.Format(_ansiColorTemplate, type, color.R, color.G, color.B);
		}

		public static Color ChangeBrightness(this Color color, float correctionFactor)
		{
			var red = (float) color.R;
			var green = (float) color.G;
			var blue = (float) color.B;

			if (correctionFactor < 0)
			{
				correctionFactor = 1 + correctionFactor;
				red *= correctionFactor;
				green *= correctionFactor;
				blue *= correctionFactor;
			}
			else
			{
				red = (255 - red) * correctionFactor + red;
				green = (255 - green) * correctionFactor + green;
				blue = (255 - blue) * correctionFactor + blue;
			}

			return Color.FromArgb(color.A, (int) red, (int) green, (int) blue);
		}
	}
}
