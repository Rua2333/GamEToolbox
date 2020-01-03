using System;

namespace Toolkit {
    public class Toolkit {

        public static void Initialize() {
        }

        public static string _RemovePrefix(string str, string prefixStr) {
            while (str.StartsWith(prefixStr))
                str = str.Remove(0, prefixStr.Length);
            return str;
        }

        public static string _GetTimeStamp_detail() {
            DateTime d = DateTime.Now;
            string timeStamp = $"{d.Year}:" +
                               $"{d.Month}:" +
                               $"{d.Day}:" +
                               $"{d.Hour}:" +
                               $"{d.Minute}:" +
                               $"{d.Second}:" +
                               $"{d.Millisecond}";
            return timeStamp;
        }

        public static string _GetTimeStamp_simple() {
            DateTime d = DateTime.Now;
            string timeStamp = $"{d.Hour}:" +
                               $"{d.Minute}:" +
                               $"{d.Second}:" +
                               $"{d.Millisecond}";
            return timeStamp;
        }
    }
}