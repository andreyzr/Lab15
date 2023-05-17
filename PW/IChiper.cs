using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW
{
    interface IChiper
    {
        string Encode(string s);
        string Decode(string s);
    }
    class AChiper : IChiper
    {
        public string Decode(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (c >= 'B' && c <= 'Z')
                    result += (char)((int)c - 1);
                else if (c == 'A')
                    result += 'Z';
                else
                    result += c;
            }
            return result;
        }

        public string Encode(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (c >= 'A' && c <= 'Y')
                    result += (char)((int)c + 1);
                else if (c == 'Z')
                    result += 'A';
                else
                    result += c;
            }
            return result;
        }
    }
    class BChiper : IChiper
    {
        public string Decode(string s)
        {
            return Encode(s);
        }

        public string Encode(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                int num = (int)c-(int)'A';
                if (c >= 'A' && c <= 'Z')
                    result +=(char) ((int)'Z'-num);
                else
                    result+=c;
            }
            return result;
        }
    }
}
