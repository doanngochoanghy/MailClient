using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MailClient
{
    class DecodeQP
    {
        public static string DecodeQuotedPrintable(string input)
        {
            var occurences = new Regex(@"(=[0-9A-Z][0-9A-Z])+", RegexOptions.Multiline);
            var matches = occurences.Matches(input);
            foreach (Match m in matches)
            {
                byte[] bytes = new byte[m.Value.Length / 3];
                for (int i = 0; i < bytes.Length; i++)
                {
                    string hex = m.Value.Substring(i * 3 + 1, 2);
                    int iHex = Convert.ToInt32(hex, 16);
                    bytes[i] = Convert.ToByte(iHex);
                }
                input = input.Replace(m.Value, Encoding.Default.GetString(bytes));
            }
            return input.Replace("=rn", "");
        }
    }
}
