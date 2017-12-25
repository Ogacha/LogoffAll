using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogoffAll
{
    public class Sessions
    {
        public string Qwinsta { get; set; }
        public Sessions() { }
        public Sessions(string qwinsta結果文字列)
        {
            Qwinsta = qwinsta結果文字列;
        }
        public List<Session> List
        {
            get
            {
                var rows = Qwinsta.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                return rows.Skip(1).Select(r => new Session
                {
                    本人=r.StartsWith(">"),
                    セッション名 = r.Substring(1, 18).Trim(),
                    ユーザー名 = r.Substring(19, 20).Trim(),
                    ID = int.Parse(r.Substring(39, 9).Trim()),
                    状態 = r.Substring(48, 8).Trim()
                }).ToList();
            }
        }
    }

    public class Session
    {
        public bool 本人 { get; set; }
        public string セッション名 { get; set; }
        public string ユーザー名 { get; set; }
        public int ID { get; set; }
        public string 状態 { get; set; }
    }
}
