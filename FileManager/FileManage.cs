using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    class FileManage
    {
        protected string filetext;
        public string newtext;
        public string filename;
        public string newfilename;
        public string path;
        public void OpenFile()
        {

            OpenFileDialog ChoosingtxtFile = new OpenFileDialog();
            ChoosingtxtFile.Filter = "Text Files | *.txt";
            var result = ChoosingtxtFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ChoosingtxtFile.FileName);
                filetext = File.ReadAllText(ChoosingtxtFile.FileName);
                filename = ChoosingtxtFile.FileName;
            }

        }

        public void Saveas(string sortingtype)
        {
            SaveFileDialog savingfile = new SaveFileDialog();
            savingfile.Filter = "Text Files | *.txt";
            var result = savingfile.ShowDialog();
            if (result == DialogResult.OK)
            {
                newfilename = savingfile.FileName;
                path = savingfile.FileName;
                newtext = new Editor().sort(filetext);
                File.WriteAllText(path, newtext);

            }

        }
    }
}
