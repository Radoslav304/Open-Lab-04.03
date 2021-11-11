using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            string a = "";
            string b = "";

            if (original.Length < 2)
            {
                return original;
            }
            a = original.Remove(0, 1);
            b = a.Remove(a.Length - 1, 1);



            return b;
        }
    }
}
