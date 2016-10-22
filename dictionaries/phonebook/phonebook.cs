using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    class phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> phonebook = new Dictionary<string, string>();
            phonebook["John Smith"]= "+1-555-8976";
            phonebook["Lisa Smith"]= "+1-555-1234";
            phonebook["Sam Doe"] = "+1-555-5030";
            phonebook["Nakov"] = "+359-899-555-592";
            phonebook["Nakov"] = "+359-2-981-9819";// this row repleaces the row above
            phonebook.Remove("John Smith");
            foreach (KeyValuePair<string,string> pair in phonebook)
            {
                Console.WriteLine("{0} --> {1}",pair.Key,pair.Value );
            }
            foreach (string key in phonebook.Keys)
            {
                Console.WriteLine($"{key}");
            }
            foreach (string value in phonebook.Values)
            {
                Console.WriteLine($"{value}");
            }
        }
    }
}
