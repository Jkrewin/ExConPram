using System;
using System.Windows.Forms;

namespace ExConPram.frm
{
    public partial class FrmCarBrand : Form
    {
        private readonly DataBase.GoodsClass.CarBrandClass UsedClass;
        private FrmMain BackForm;

        public FrmCarBrand(DataBase.GoodsClass.CarBrandClass carBrandClass)
        {
            InitializeComponent();
            UsedClass = carBrandClass;
        }

        private void FrmCarBrand_Load(object sender, EventArgs e)
        {
            BackForm = this.Tag as FrmMain;
            WorkForm.FillForm(this, UsedClass);
            if (UsedClass.ID != -1) { Button_OK.Text = "Изменить"; }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (WorkForm.DataValidator(UsedClass) == false) return;
            WorkForm.GetDataObj(this, UsedClass);
            UsedClass.Update(Program.MainForm.SQLCommander);
            WorkForm.GetDataComboBox("CarBrandClass", "NameBrand", BackForm.MachineBrandBox, Program.MainForm.SQLCommander);
            BackForm.MachineBrandBox.Text = NameBrand.Text;
            Button_Cancel_Click(null, null);
        }

        private void FrmCarBrand_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackForm.Enabled = true;
            BackForm.Select();
        }
    }
}
