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
            if (text == "merge")
            {
                return finaltext(mergesort(makeintlist(seperate(finding_seperators(text), text))), delimeters);
            }
            else if (text == "selection")
            {
                return finaltext(selectionsort(makeintlist(seperate(finding_seperators(text), text))), delimeters);
            }
            else
            {
                return finaltext(bublesort(makeintlist(seperate(finding_seperators(text), text))), delimeters);
            }
            
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
        public List<int> selectionsort(List<int> tobesort)
        {

            for (int i = 0; i < tobesort.Count; i++)
            {
                Tuple<int, int> minvalues = findingminvalues(tobesort, i);
                int minvalue = minvalues.Item1;
                int minindex = minvalues.Item2;

                if (tobesort[i] > minvalue)
                {
                    var temp = tobesort[i];
                    tobesort[i] = minvalue;
                    tobesort[minindex] = temp;
                }

            }
            return tobesort;
        }
        public Tuple<int, int> findingminvalues(List<int> finding, int startIndex)
        {
            var array = finding.ToArray();
            var list = array.Skip(startIndex).Take(array.Length - startIndex + 1).ToList();

            int minvalue = list.Min();
            int minindex = list.IndexOf(minvalue) + startIndex;
            return new Tuple<int, int>(minvalue, minindex);
        }
        public List<int> bublesort(List<int> tobesort)
        {
            for (int i = 0; i < tobesort.Count - 1; i++)
            {
                for (int j = 0; j < tobesort.Count - 1; j++)
                {
                    if (tobesort[j] > tobesort[j + 1])
                    {
                        var temp = tobesort[j];
                        tobesort[j] = tobesort[j + 1];
                        tobesort[j + 1] = temp;
                    }
                }
            }

            return tobesort;
        }
        public List<int> mergesort(List<int> tobesort)
        {
            return tobesort;
        }
    }
}
