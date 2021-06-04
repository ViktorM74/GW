using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Distinary;
using FileAction;

namespace FolderManager
{
    public partial class Form_FolderManager : Form
    {
        private List<string> listLocalValue = new List<string>();
        private List<string> listServerValue = new List<string>();

        public List<string> listLocal
        {
            get {
                return listLocalValue;
            }
        }

        public List<string> listServer
        {
            get {
                return listServerValue;
            }
        }

        string pathLocal = "";
        string pathServer = "";

        CheckBox[] ChckGroup;

        bool vCopy;
        public Form_FolderManager(string pathLocal, string pathServer, bool viewCopy)
        {
            InitializeComponent();

            this.pathLocal = pathLocal;
            this.pathServer = pathServer;

            vCopy = viewCopy;

            ChckGroup = new CheckBox[] { ch_DogovorFld, ch_GeoFld, ch_StampFld, ch_ZadaniaFld, ch_OtherFld, ch_OsnFld, ch_InFld, ch_OutFld, ch_FreeNameFld };

            if (!vCopy)
                SetViewCreate(pathLocal, pathServer);
            else
                SetViewCopy(pathLocal, pathServer);
        }

        private void SetViewCopy(string pathLocal, string pathServer)
        {
            SetViewCreate(pathLocal, pathServer);
            gr_Folders.Text = "Папки...";
            gr_fldSorce.Text = "Направление... ";
            bt_CreateFld.Text = "Копировать";
            btn_DeleteFld.Text = "Переместить";
            this.Text = "Выберите направление, папку и действие для выбранных файлов";

        }

        private void SetViewCreate(string pathLocal, string pathServer)
        {
            if (Directory.Exists(pathLocal))
                ch_WorkFld.Enabled = true;
            else
                ch_WorkFld.Enabled = false;


            if (Directory.Exists(pathServer))
                ch_ServerFld.Enabled = true;
            else
                ch_ServerFld.Enabled = false;

            ExistFolders();
            ActiveChck(ChckGroup);
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            listLocalValue.Clear();
            listServerValue.Clear();
            Close();
        }

        private void bt_CreateFld_Click(object sender, EventArgs e)
        {
            if (!vCopy)
            {
                CreateFolders();
                ExistFolders();
            }

        }

        private void CreateFolders() // создание папок по списку
        {
            CreateLists(ChckGroup);

            if (pathLocal != "")
            {
                foreach (string s in listLocalValue)
                {
                    FileA.CreateFolder(s, pathLocal);
                }
            }

            if (pathServer != "")
            {
                foreach (string s in listServerValue)
                {
                    FileA.CreateFolder(s, pathServer);
                }
            }
        }

        private void DeleteFolders() // удаление папок по списку
        {
            CreateLists(ChckGroup);
            if (pathLocal != "")
            {
                foreach (string s in listLocalValue)
                {
                    string p = Path.Combine(pathLocal, s);
                    FileA.DeleteFolder(p);
                }
            }

            if (pathServer != "")
            {
                foreach (string s in listServerValue)
                {
                    string p = Path.Combine(pathServer, s);
                    FileA.DeleteFolder(p);
                }
            }
        }

        private void ExistFolders() // проверка наличия папок
        {
            void EV(CheckBox cBox, string path, string Name)
            {
                string fpath = path + "\\" + Name;
                cBox.Checked = Directory.Exists(fpath);

            }
            //
            //0"Исходные данные",
            //1"Письма",
            //2"Задания",
            //3"Тендер",
            //4"Договор",
            //5"График",
            //6"Объект",
            //7"Изыскания",
            //8"Штамп",
            //9"Разное",
            //10"Основные положения",
            //11"Входящие",
            //12"Исходящие"
            EV(ch_dw, pathLocal, Libr.NameFld[4]); // Договор
            EV(ch_gw, pathLocal, Libr.NameFld[7]); //Изыскания
            EV(ch_sw, pathLocal, Libr.NameFld[8]); //Штамп
            EV(ch_zw, pathLocal, Libr.NameFld[2]); //Задания
            EV(ch_ow, pathLocal, Libr.NameFld[9]); //Разное
            EV(ch_osw, pathLocal, Libr.NameFld[10]); //Основные положения
            EV(ch_inw, pathLocal, Path.Combine(Libr.NameFld[1], Libr.NameFld[11])); //Входящие
            EV(ch_outw, pathLocal, Path.Combine(Libr.NameFld[1], Libr.NameFld[12])); //Исходящие

            EV(ch_ds, pathServer, Libr.NameFld[4]);
            EV(ch_gs, pathServer, Libr.NameFld[7]);
            EV(ch_ss, pathServer, Libr.NameFld[8]);
            EV(ch_zs, pathServer, Libr.NameFld[2]);
            EV(ch_os, pathServer, Libr.NameFld[9]);
            EV(ch_oss, pathServer, Libr.NameFld[10]);
            EV(ch_ins, pathServer, Path.Combine(Libr.NameFld[1], Libr.NameFld[11]));
            EV(ch_outs, pathServer, Path.Combine(Libr.NameFld[1], Libr.NameFld[12]));


        }

        private void btn_DeleteFld_Click(object sender, EventArgs e)
        {
            if (!vCopy)
            {
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить папки со всем содержимым? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    DeleteFolders();
                    ExistFolders();
                }
            }


        }

        private void clkCheckers(CheckBox cb)
        {
            int iTag = Convert.ToInt32(cb.Tag);
            string name = Libr.NameFld[iTag];
            if (cb.Checked)
            {
                if (ch_WorkFld.Checked)
                {
                    if (iTag == 11 || iTag == 12)
                        name = Path.Combine(Libr.NameFld[1], Libr.NameFld[iTag]);
                    listLocalValue.Add(name);
                }

                if (ch_ServerFld.Checked)
                {
                    if ((int)cb.Tag == 11 || (int)cb.Tag == 12)
                        name = Path.Combine(Libr.NameFld[1], Libr.NameFld[iTag]);
                    listServerValue.Add(name);
                }

            }
        }

        private void CreateLists(CheckBox[] chg)
        {
            listLocalValue.Clear();
            listServerValue.Clear();

            foreach (CheckBox cb in chg)
            {
                clkCheckers(cb);
            }
        }

        private void ActiveChck(CheckBox[] chg)
        {
            if (ch_WorkFld.Checked || ch_ServerFld.Checked)
            {
                foreach (CheckBox cb in chg)
                {
                    cb.Enabled = true;

                }
                ch_FreeNameFld.Enabled = true;

            }
            else
            {
                foreach (CheckBox cb in chg)
                {
                    cb.Enabled = false;

                }
                tb_NewNameFld.Enabled = false;
            }
        }

        #region CheckedChanged

        private void ch_WorkFld_CheckedChanged(object sender, EventArgs e)
        {
            ActiveChck(ChckGroup);
        }
        private void ch_ServerFld_CheckedChanged(object sender, EventArgs e)
        {
            ActiveChck(ChckGroup);
        }
        #endregion


    }
}
