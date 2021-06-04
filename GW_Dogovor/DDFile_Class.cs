using System.Collections.Generic;
using System.Windows.Forms;

namespace GW_Dogovor
{
    class DDFile_Class
    {
        public static List<string> GetListFiles(DragEventArgs e)
        {
            List<string> pathDocList = new List<string>(); // список полных путей передаваемых файлов(папок)


            foreach (string fobj in (string[])e.Data.GetData(DataFormats.FileDrop)) // формирование списков путей
            {
                //string n = Path.GetFileName(fobj); // получение имени из пути
                pathDocList.Add(fobj);

            } // формирование списков путей

            return pathDocList;
        }

    }
}
