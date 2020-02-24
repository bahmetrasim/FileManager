using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class Editor

    {
        char[] delimeters;
        public string sort(string text)
        {
            return finaltext(ascendingsorted( makeintlist(seperate(finding_seperators(text), text))), delimeters);
        }
        public char[] finding_seperators(string text)
        {
            char[] stringtochar = text.ToArray();
           
            for (int i = 0; i < stringtochar.Length; i++)
            {
                int a;
                if (!int.TryParse(stringtochar[i].ToString(), out a))
                {
                    List<char> seperatorchars = new List<char>();
                    do
                    {
                        seperatorchars.Add(stringtochar[i]);
                        i++;
                    }
                    while (!int.TryParse(stringtochar[i].ToString(), out a));
                    delimeters = new char[seperatorchars.Count];
                    for (int j = 0; j < seperatorchars.Count; j++)
                    {
                        delimeters[j] = seperatorchars[j];
                    }
                    return delimeters;
                }
            }
            return new char[] { };
        }
        public string[] seperate(char[] seperator, string text)
        {
            string[] texttostring;
            return texttostring = text.Split(seperator);
        }
        public List<int> makeintlist(string[] seperatedtext)
        {
            List<int> texttointlist = new List<int>();

            foreach (var item in seperatedtext)
            {
                int a;
                if (int.TryParse(item, out a))
                {
                    texttointlist.Add(int.Parse(item));
                }
            }
            return texttointlist;
        }
        public string[] inttostringarray(List<int> intlist)
        {
            string[] textarray = new string[intlist.Count()];
            int[] textnumbers = intlist.ToArray();
            for (int i = 0; i < intlist.Count; i++)
            {
                textarray[i] = intlist[i].ToString();
            }
            return textarray;
        }
        public List<int> descendingsorted(List<int> intlist)
        {
            intlist.Sort();
            return intlist;
        }
        public List<int> ascendingsorted(List<int> intlist)
        {
            descendingsorted(intlist).Reverse();
            return intlist;
        }
        public string finaltext(List<int> sorted, char[] delimeters)
        {
            string seperatevalue = "";
            foreach (var item in delimeters)
            {
                seperatevalue = seperatevalue + item.ToString();
            }
            string text = string.Join(seperatevalue, inttostringarray(sorted));

            return text;
        }
    }
}
