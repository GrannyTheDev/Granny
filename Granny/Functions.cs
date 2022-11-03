using System.IO;
using System.Windows.Forms;

namespace Granny
{
    internal class Functions
    {
        public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }
        public static OpenFileDialog openfiledialog = new OpenFileDialog
        {
            Filter = "Lua Script (*.lua)|*.lua|Txt Script (*.txt)|*.txt|All files (*.*)|*.*",
            FilterIndex = 1,
            RestoreDirectory = true,
            Title = "Granny"
        };
    }
}
