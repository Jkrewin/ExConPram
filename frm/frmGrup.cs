using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExConPram.frm
{
    public partial class FrmGrup : Form
    {
        private readonly DataBase.GoodsClass.GrupClass UsedClass;
        private FrmMain BackForm;

        public FrmGrup(DataBase.GoodsClass.GrupClass grupClass)
        {
            InitializeComponent();
            UsedClass = grupClass;
        }

        private void FrmGrup_Load(object sender, EventArgs e)
        {
            BackForm = this.Tag as FrmMain;
            WorkForm.FillForm(this, UsedClass);
            Color_crm.SelectedIndex = 0;
            if (UsedClass.ID !=-1) { Button_OK.Text = "Изменить"; }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (WorkForm.DataValidator(UsedClass) == false) return;
            WorkForm.GetDataObj(this, UsedClass);
 UsedClass.ColorField  = Color.FromName(Color_crm.Text[1..Color_crm.Text.IndexOf(']')]); //преобразует текст в цвет

            UsedClass.Update(Program.MainForm.SQLCommander);

           

            WorkForm.GetDataComboBox("GrupClass", "TypeCar", BackForm.GrupClassBox, Program.MainForm.SQLCommander);
            BackForm.GrupClassBox.Text = TypeCar.Text;
            Button_Cancel_Click(null, null);
        }

        private void FrmGrup_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackForm.Enabled = true;
            BackForm.Select();
        }
    }
}
