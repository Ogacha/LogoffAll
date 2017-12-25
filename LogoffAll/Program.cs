using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LogoffAll
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("qwinsta");
            var logons = new Sessions(コマンド係.実行("qwinsta",""));
            var ids = from e in logons.List
                      where e.ユーザー名 != "" && !e.本人
                      select e.ID;
            foreach (var id in ids)
            {
                //var cmd = "logoff " + id.ToString();
                //Console.WriteLine(cmd);
                コマンド係.実行("logoff", id.ToString());
            }
        }
    }
}
