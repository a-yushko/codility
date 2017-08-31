using System;
using System.Collections;
using System.Linq;

namespace Assesment.Strings
{
    public static class StringTask
    {
        /// <summary>
        /// Determine if a string has all unique characters. What if you cannot use additional data structures?
        /// </summary>
        /// <param name="str">String to check</param>

        public static bool AllUnique(string str)
        {
            Hashtable chars = new Hashtable();
            foreach (char c in str)
            {
                var key = Char.ToUpper(c);
                if (chars.ContainsKey(key))
                    return false;
                chars.Add(key, null);
            }
            return true;
        }

        public static bool AllUnique2(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (Char.ToUpper(str[i]) == Char.ToUpper(str[j]))
                        return false;
                }
            return true;
        }

        public static bool AllUnique3(string str)
        {
            var charArray = str.ToUpper().ToArray();
            Array.Sort(charArray);
            for (int i = 0; i < charArray.Length - 1; i++)
            {
                if (Char.ToUpper(charArray[i]) == Char.ToUpper(charArray[i + 1]))
                    return false;
            }
            return true;
        }
    }
}
