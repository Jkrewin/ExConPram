using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExConPram
{

    public partial class ChooseSql : Form
    {
        private List<Control> ControlList;
        private ConnectionSettings connectionSettings = new ConnectionSettings();
        private readonly BinaryFormatter binaryFormatter = new BinaryFormatter();
        private string SetFile { get; } = AppContext.BaseDirectory + "SetFile.dat";
        private readonly Main.Sqlite_Commander sqlite = new Main.Sqlite_Commander();
        private readonly Main.MsSql_Commander ms = new Main.MsSql_Commander();


        [Serializable]
        public class ConnectionSettings
        {
            public Dictionary<string, string> Set_dic = new Dictionary<string, string>();
            public int SelectTab = 0;
        }


        public ChooseSql() => InitializeComponent();

        private async void SqlRun()
        {
            ProgressBar1.Visible = true;
            await Task.Run(() => Task.Delay(1000));
            try
            {
                Program.MainForm.SQLCommander.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД. " + ex.Message);
                return;
            }

            //создаем таблици если их нет
            Program.MainForm.SQLCommander.CreateTabel<DataBase.GoodsClass>();
            Program.MainForm.SQLCommander.CreateTabel<DataBase.GoodsClass.CarBrandClass>();
            Program.MainForm.SQLCommander.CreateTabel<DataBase.GoodsClass.GrupClass>();
            Program.MainForm.SQLCommander.CreateTabel<DataBase.GoodsClass.ModificationClass>();

            //Сохраняем успешную сборку
            using FileStream fs = new FileStream(SetFile, FileMode.OpenOrCreate);
            binaryFormatter.Serialize(fs, connectionSettings);

            Program.MainForm.Refreh_DataGridViewMain();
            Program.MainForm.Enabled = true;
            Program.MainForm.Select();
            this.Close();
        }       

        /// <summary>
        /// Finds all controls on a form
        /// </summary>
        /// <param name="container"></param>
        private void GetAllControls(Control container)
        {
            foreach (Control item in container.Controls)
            {
                GetAllControls(item);
                ControlList.Add(item);
            }
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e) => Password_con.PasswordChar = checkBox1.Checked == true ? '0' : '*';
        private void Button2_Click(object sender, EventArgs e)
        {
            sqlite.LocalDB = LocalDB.Text;
            Program.MainForm.SQLCommander = sqlite;
            SqlRun();
        }
        private void ChooseSql_Load(object sender, EventArgs e)
        {
            ControlList = new List<Control>();
            GetAllControls(this);

            if (File.Exists(SetFile) == false)
            {
                foreach (var item in sqlite.GetType().GetProperties())
                    if (item.CanWrite) connectionSettings.Set_dic.Add(item.Name, item.GetValue(sqlite).ToString());
                foreach (var item in ms.GetType().GetProperties())
                    if (item.CanWrite) connectionSettings.Set_dic.Add(item.Name, item.GetValue(ms).ToString());
            }
            else
            {
                using FileStream fs = new FileStream(SetFile, FileMode.Open);
                connectionSettings = binaryFormatter.Deserialize(fs) as ConnectionSettings;
                TabControl1.SelectedIndex = connectionSettings.SelectTab;
            }

            foreach (Control tv in ControlList)
            {
                if (connectionSettings.Set_dic.ContainsKey(tv.Name))
                {
                    if (tv.GetType().Name == "TextBox") { ((TextBox)tv).Text = connectionSettings.Set_dic[tv.Name]; }
                    else if (tv.GetType().Name == "CheckBox") { ((CheckBox)tv).Checked = bool.Parse(connectionSettings.Set_dic[tv.Name]); }
                }
            }
            this.Focus();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            ms.Database_conString = Database_conString.Text;
            ms.MultipleActiveResultSets = MultipleActiveResultSets.Checked;
            ms.Password_con = Password_con.Text;
            ms.UserId_con = UserId_con.Text;
            ms.Server_conString = Server_conString.Text;
            ms.TrustServerCertificate = TrustServerCertificate.Checked;
            Program.MainForm.SQLCommander = ms;
            SqlRun();
        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e) => connectionSettings.SelectTab = TabControl1.SelectedIndex;


    }
}
