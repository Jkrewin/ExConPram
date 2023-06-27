using System;
using System.Windows.Forms;

namespace ExConPram
{
    public partial class Form1 : Form
    {

        public Main.ISQLCommander SQLCommander = new Main.Sqlite_Commander();

        private frm.FrmMain frmMain;

        public Form1() => InitializeComponent();

        public void Refreh_DataGridViewMain()
        {
            DataGridViewMain.Rows.Clear();

            string sqlStr= "ID > 0 LIMIT 200";
            if (CBox1.Checked) sqlStr = "ID > 0 AND Status ='1' LIMIT 200";

            var ls = SQLCommander.CollectionList<DataBase.GoodsClass>(sqlStr);

            string[] row = new string[7];
            foreach (var item in ls)
            {
                row[0] = item.ID.ToString();
                row[1] = item.MachineBrand.NameBrand;
                row[2] = item.Modification.TypeEngine;
                row[3] = item.Status.ToString();
                row[4] = item.Сountry;
                row[5] = ((item.Price * (item.MarkupSng / 100)) + item.Price).ToString();
                row[6] = item.Grup.TypeCar;
                DataGridViewMain.Rows.Add(row);
                DataGridViewMain.Rows[^1].DefaultCellStyle.BackColor = item.Grup.ColorField;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLCommander.Connect();
            if (SQLCommander.ConnectIs == false) { 
                MessageBox.Show("No database connection !");
                return;
            }
            //создаем таблици если их нет
            SQLCommander.CreateTabel<DataBase.GoodsClass>();
            SQLCommander.CreateTabel<DataBase.GoodsClass.CarBrandClass>();
            SQLCommander.CreateTabel<DataBase.GoodsClass.GrupClass>();
            SQLCommander.CreateTabel<DataBase.GoodsClass.ModificationClass>();

            Refreh_DataGridViewMain();
        }

        private void ADD_button1_Click(object sender, EventArgs e)
        {
            frmMain = new frm.FrmMain(new DataBase.GoodsClass()) { Tag = this };
            frmMain.Show();
            this.Enabled = false;
        }

        private void Del_button3_Click(object sender, EventArgs e)
        {
            if (DataGridViewMain.SelectedCells.Count > 0)
            {               
                DataGridViewRow selectedRow = DataGridViewMain.Rows[DataGridViewMain.SelectedCells[0].RowIndex];
                string id = selectedRow.Cells["ID"].FormattedValue.ToString() ;
                SQLCommander.Delete("GoodsClass", int.Parse(id));
                Refreh_DataGridViewMain();
            }
        }

        private void Edit_button2_Click(object sender, EventArgs e)
        {
            if (DataGridViewMain.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridViewMain.Rows[DataGridViewMain.SelectedCells[0].RowIndex];
                string id = selectedRow.Cells["ID"].FormattedValue.ToString();
                DataBase.GoodsClass goods = new DataBase.GoodsClass();
                goods.GetDate(int.Parse(id),SQLCommander);
                frmMain = new frm.FrmMain(goods) { Tag = this };
                frmMain.Show();
                this.Enabled = false;
            }
        }

        private void CBox1_CheckedChanged(object sender, EventArgs e) => Refreh_DataGridViewMain();
    }
}
