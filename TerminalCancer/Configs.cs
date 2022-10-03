using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalCancer
{
    public static class Configs
    {
        private static Dictionary<string, Color> ThemesCollection = new Dictionary<string, Color>
        {
            {"Dark", Color.DarkGray },
            {"Light", Color.White },
            {"Black", Color.Black },
            {"Yellow", Color.Yellow },
            {"Blue", Color.Blue },
            {"Green", Color.Green }
        };

        public static Color GetTheme(string ColorName)
        {
            return ThemesCollection[ColorName];
        }
    }
}
