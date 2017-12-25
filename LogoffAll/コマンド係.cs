using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LogoffAll
{
    public class コマンド係
    {
        public static string 実行(string コマンド,string 引数)
        {
            var psInfo = new ProcessStartInfo
            {
                FileName = コマンド,
                Arguments=引数,
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true
            };
            var process = Process.Start(psInfo);
            return process.StandardOutput.ReadToEnd();
        }
    }
}
