using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class Editor

    {
        public string sort (string text)
        {
            return descendingtext(makeintlist(text));
        }
        public List<int> makeintlist (string text)
        {
            List<int> texttointlist = new List<int>();
            string[] texttostring = text.Split(',');

            foreach (var item in texttostring)
            {
                int a;
                if (int.TryParse(item,out a))
                {
                    texttointlist.Add(int.Parse(item));
                }
            }
            return texttointlist;
        }
        public string descendingtext(List<int> sorted)
        {
            
            string text = "";
            sorted.Sort();
            for (int i = 0; i < sorted.Count; i++)
            {
                text = text + sorted[i] + ","  ;
            }
            return text;
        }
    }
}
