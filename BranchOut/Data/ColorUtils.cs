using System.Globalization;

namespace BranchOut.Data
{
    public class ColorUtils
    {
        public static string LightenColor(string hexColor, double factor = 0.2)
        {
            if (hexColor.StartsWith("#"))
                hexColor = hexColor.Substring(1);

            if (hexColor.Length != 6)
                throw new ArgumentException("Invalid hex color format.");

            // Convert hex to RGB
            int r = int.Parse(hexColor.Substring(0, 2), NumberStyles.HexNumber);
            int g = int.Parse(hexColor.Substring(2, 2), NumberStyles.HexNumber);
            int b = int.Parse(hexColor.Substring(4, 2), NumberStyles.HexNumber);

            // Convert to HSL
            double h, s, l;
            RgbToHsl(r, g, b, out h, out s, out l);

            l = Math.Min(1, l + factor); 

            // Convert back to RGB
            HslToRgb(h, s, l, out r, out g, out b);

            // Convert back to hex
            return $"#{r:X2}{g:X2}{b:X2}";
        }

        private static void RgbToHsl(int r, int g, int b, out double h, out double s, out double l)
        {
            double rNorm = r / 255.0;
            double gNorm = g / 255.0;
            double bNorm = b / 255.0;

            double max = Math.Max(rNorm, Math.Max(gNorm, bNorm));
            double min = Math.Min(rNorm, Math.Min(gNorm, bNorm));
            double delta = max - min;

            h = s = 0;
            l = (max + min) / 2;

            if (delta > 0)
            {
                s = l > 0.5 ? delta / (2 - max - min) : delta / (max + min);

                if (max == rNorm)
                    h = (gNorm - bNorm) / delta + (gNorm < bNorm ? 6 : 0);
                else if (max == gNorm)
                    h = (bNorm - rNorm) / delta + 2;
                else
                    h = (rNorm - gNorm) / delta + 4;

                h /= 6;
            }
        }

        private static void HslToRgb(double h, double s, double l, out int r, out int g, out int b)
        {
            if (s == 0)
            {
                r = g = b = (int)(l * 255);
                return;
            }

            double q = l < 0.5 ? l * (1 + s) : l + s - l * s;
            double p = 2 * l - q;

            r = (int)(255 * HueToRgb(p, q, h + 1.0 / 3.0));
            g = (int)(255 * HueToRgb(p, q, h));
            b = (int)(255 * HueToRgb(p, q, h - 1.0 / 3.0));
        }

        private static double HueToRgb(double p, double q, double t)
        {
            if (t < 0) t += 1;
            if (t > 1) t -= 1;
            if (t < 1.0 / 6.0) return p + (q - p) * 6 * t;
            if (t < 1.0 / 2.0) return q;
            if (t < 2.0 / 3.0) return p + (q - p) * (2.0 / 3.0 - t) * 6;
            return p;
        }
}

// Example usage:
//string lighterColor = ColorUtils.LightenColor("#33629E", 0.2); // Two shades lighter
//Console.WriteLine(lighterColor);
}
