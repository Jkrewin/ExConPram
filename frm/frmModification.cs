using System;
using System.Windows.Forms;

namespace ExConPram.frm
{
    public partial class FrmModification : Form
    {
        private readonly DataBase.GoodsClass.ModificationClass UsedClass;
        private FrmMain BackForm;

        public FrmModification(DataBase.GoodsClass.ModificationClass modificationClass)
        {
            InitializeComponent();
            UsedClass = modificationClass;
        }

        private void FrmModification_Load(object sender, EventArgs e)
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
            WorkForm.GetDataComboBox("ModificationClass", "TypeEngine", BackForm.ModificationBox, Program.MainForm.SQLCommander);
            BackForm.ModificationBox.Text = TypeEngine.Text;
            Button_Cancel_Click(null, null);
        }
        private void TypeEngine_Leave(object sender, EventArgs e) => WorkForm.NormalizationTextBox((TextBox)sender, UsedClass);

        private void FrmModification_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackForm.Enabled = true;
            BackForm.Select();
        }
    }
}
