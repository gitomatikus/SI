﻿using System.Linq;
using System.Windows.Media;
using SIUI.ViewModel.Core;

namespace SIUI
{
    public static class SettingsHelper
    {
        public static string[] FontFamilies { get; private set; }
        public static double[] LineSpaces { get; private set; }

        static SettingsHelper()
        {
            FontFamilies = new string[] { Settings.DefaultTableFontFamily }.Concat(Fonts.SystemFontFamilies.Select(ff => ff.ToString()).OrderBy(s => s)).ToArray();
            LineSpaces = new double[] { 1.0, Settings.DefaultQuestionLineSpacing };
        }
    }
}
