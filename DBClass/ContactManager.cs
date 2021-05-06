using System;
using System.Windows.Forms;

namespace DBClass
{
    public partial class ContactManager : Form
    {
        string tProvider;
        string tPathDB;
        string tLogin = "Admin";
        string tPassword = "";

        public ContactManager()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Access files(*.accdb)|*.accdb|Access files(*.mdb)|*.mdb"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {   // получаем выбранный файл
                string filename = openFileDialog1.FileName;
                textBox1.Text = filename;

            }
        }

        private void ContactManager_Load(object sender, EventArgs e)
        {
            AppSetting setting = new AppSetting();

            string connStr = setting.GetConnectionString("DBClass.Properties.Settings.dbs_ConnectString");
            string[] s = setting.GetParametrConnectionString(connStr);
            tProvider = s[1];
            tPathDB = s[3];
            textBox1.Text = tPathDB;
            tLogin = "Admin";
            tPassword = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connectstring = string.Format("Provider={0};Data Source={1};Jet OLEDB:Database Password={3};", textBoxProvider.Text, textBoxDataSource.Text, textBoxPassword.Text);
            tPathDB = textBox1.Text;
            string connectstring = string.Format("Provider={0};Data Source={1}", tProvider, tPathDB);
            try
            {
                MSAccessHelper helper = new MSAccessHelper(connectstring);
                if (helper.IsConnection)
                {
                    MessageBox.Show("Соединение успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tPathDB = textBox1.Text;
            string connectstring = string.Format("Provider={0};Data Source={1}", tProvider, tPathDB);
            try
            {
                MSAccessHelper helper = new MSAccessHelper(connectstring);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SetConnectionString("DBClass.Properties.Settings.dbs_ConnectString", connectstring);
                    MessageBox.Show("Соединение успешно сохранено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
