using System;
using System.Collections;
using System.Text;

namespace Common.Collections
{
    public static class Extensions
    {
        public static void AddRange(this Hashtable hashtable, Hashtable add)
        {
            foreach (var key in add.Keys)
            {
                hashtable[key] = add[key];
            }
        }
    }
}
