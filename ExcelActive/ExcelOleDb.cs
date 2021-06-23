using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelActive
{
    public class ExcelOleDb
    {
        public static DataTable ReadXlsxToTable(string path, string name)
        {
            DataTable dataTable = new DataTable();

            if (File.Exists(path))
            {
                string excelConnectionString = GetExcelConnection(path);
                
                if (excelConnectionString != null)
                    using (OleDbConnection excelConnection = new OleDbConnection(excelConnectionString))
                    {
                        try
                        {
                            excelConnection.Open();
                            string comand = String.Format("SELECT * FROM [{0}$]", name);
                            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(comand, excelConnection);
                            dataAdapter.Fill(dataTable);
                            excelConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка загрузки файла Excel. Проверьте имя таблицы.",
                                "Ошибка загрузки");
                        }

                    }
            }
            else
                MessageBox.Show("Файл не найден!", "Ошибка загрузки");

            return dataTable;
        }

        private static string GetExcelConnection(string path)
        {///HDR=No - первая строка не содержит имена столбцов
            FileInfo fi = new FileInfo(path);
            if (fi.Extension == ".xls")
              return String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};
                                       Extended Properties='Excel 8.0;HDR=YES';", path);
            if (fi.Extension == ".xlsm")
              return String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};
                                      Extended Properties='Excel 12.0 Macro;HDR=YES';", path);
            if (fi.Extension == ".xlsx")          
              return String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};
                                     Extended Properties='Excel 12.0 Xml;HDR=Yes';", path);

            return null;
        }

        public static List<string> GetListTables(string path)
        {
            List<string> list = new List<string>();
            DataTable table = new DataTable();

            if (File.Exists(path))
            {
                string excelConnectionString = GetExcelConnection(path);

                if (excelConnectionString != null)
                    using (OleDbConnection excelConnection = new OleDbConnection(excelConnectionString))
                    {
                        excelConnection.Open();
                        table = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        if (table != null)
                        {
                            foreach (DataRow row in table.Rows)
                            {
                                list.Add(row["TABLE_NAME"].ToString());
                            }
                            excelConnection.Close();
                            return list;
                        }
                    }
            }

            return null;
        }


    }
}
