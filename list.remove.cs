using System;
using System.Text;
using System.Collections.Generic;

namespace listInsert
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<string> ds = new List<string> ();
            ds.Add("Trần");
            ds.Add("Trọng");
            ds.Add("Hòa");
            ds.Remove("Hòa");
            ds.RemoveAt(0);
            foreach (string s in ds)
            {
                Console.WriteLine (s);
            }
        }
    }
}
