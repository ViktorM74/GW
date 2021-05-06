using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FileAction;

namespace FolderManager
{
    public partial class Form_FolderManager : Form
    {
        private List<string> listLocalValue = new List<string>();
        private List<string> listServerValue = new List<string>();

        public List<string> listLocal
        {
            get { return listLocalValue; }
        }

        public List<string> listServer
        {
            get { return listServerValue; }
        }

        string pathLocal = "";
        string pathServer = "";

        string[] NameFld = { "Договор", "Изыскания", "Штамп", "Задания", "Разное", "Основные положения", "Входящие", "Исходящие" };

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
            void EV(CheckBox cBox, string path, int iName)
            {
                string fpath = path + "\\" + NameFld[iName];
                cBox.Checked = Directory.Exists(fpath);

            }

            EV(ch_dw, pathLocal, 0);
            EV(ch_gw, pathLocal, 1);
            EV(ch_sw, pathLocal, 2);
            EV(ch_zw, pathLocal, 3);
            EV(ch_ow, pathLocal, 4);
            EV(ch_osw, pathLocal, 5);
            EV(ch_inw, pathLocal, 6);
            EV(ch_outw, pathLocal, 7);

            EV(ch_ds, pathServer, 0);
            EV(ch_gs, pathServer, 1);
            EV(ch_ss, pathServer, 2);
            EV(ch_zs, pathServer, 3);
            EV(ch_os, pathServer, 4);
            EV(ch_oss, pathServer, 5);
            EV(ch_ins, pathServer, 6);
            EV(ch_outs, pathServer, 7);


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
            if (cb.Checked)
            {
                if (ch_WorkFld.Checked)
                    listLocalValue.Add(cb.Text);
                if (ch_ServerFld.Checked)
                    listServerValue.Add(cb.Text);
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
