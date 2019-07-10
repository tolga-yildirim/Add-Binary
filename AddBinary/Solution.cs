using System;
using System.Collections.Generic;
using System.Text;

namespace AddBinary
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            if (String.IsNullOrEmpty(a) && String.IsNullOrEmpty(b))
            {
                return null;
            }
            else if (String.IsNullOrEmpty(a))
            {
                return b;
            }
            else if (String.IsNullOrEmpty(b))
            {
                return a;
            }

            StringBuilder sb = new StringBuilder();
            int la = a.Length;
            int lb = b.Length;
            int minLen = Math.Min(la, lb);
            int carry = 0;
            int i;
            for (i = 1; i <= minLen; i++)
            {
                sb.Insert(0, AddTwoBits(a[la - i], b[lb - i], ref carry));
            }

            if (la == lb)
            {
                if (carry == 1)
                {
                    sb.Insert(0, "1");
                }
            }
            else
            {
                string longerNumber;
                int maxLen = Math.Max(la, lb);
                if (i <= la)
                {
                    longerNumber = a;
                }
                else
                {
                    longerNumber = b;
                }

                for (int j = i; j <= maxLen; j++)
                {
                    sb.Insert(0, AddTwoBits(longerNumber[maxLen - j], '0', ref carry));
                }
                if (carry == 1)
                {
                    sb.Insert(0, "1");
                }
            }

            return sb.ToString();
        }

        private string AddTwoBits(char b1, char b2, ref int carry)
        {
            int d1 = Convert.ToInt32(b1.ToString());
            int d2 = Convert.ToInt32(b2.ToString());
            int sum = d1 + d2 + carry;
            carry = (sum & 2) > 0 ? 1 : 0;
            return (sum & 1).ToString();
        }
    }
}
