using System;
using System.Windows.Forms;

namespace ExConPram.frm
{
    public partial class FrmMain : Form
    {
        private int Selector = 1;
        private readonly DataBase.GoodsClass UsedClass;
        private Form1 BackForm;
        private FrmCarBrand CarBrand;
        private FrmGrup Grup;
        private FrmModification Modification;

        public FrmMain(DataBase.GoodsClass goodsClass)
        {
            InitializeComponent();
            UsedClass = goodsClass;
        }

        private void SelectItem(ComboBox combo, string text)
        {
            for (int i = 0; i < combo.Items.Count - 1; i++)
            {
                if (((WorkForm.DeliveredClass)combo.Items[i]).Name == text)
                {
                    combo.SelectedIndex = i;
                    return;
                }
            }
        }
        private void Refreh_Combobox() {
            WorkForm.GetDataComboBox("CarBrandClass", "NameBrand", MachineBrandBox, Program.MainForm.SQLCommander);
            WorkForm.GetDataComboBox("ModificationClass", "TypeEngine", ModificationBox, Program.MainForm.SQLCommander);
            WorkForm.GetDataComboBox("GrupClass", "TypeCar", GrupClassBox, Program.MainForm.SQLCommander);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            BackForm = this.Tag as Form1;
            Refreh_Combobox();
            Status.DataSource = Enum.GetValues(typeof(DataBase.GoodsClass.StatusEnum));
            WorkForm.FillForm(this, UsedClass);

            if (UsedClass.MachineBrand != null) SelectItem(MachineBrandBox, UsedClass.MachineBrand.NameBrand);
            if (UsedClass.Modification != null) SelectItem(ModificationBox, UsedClass.Modification.TypeEngine);
            if (UsedClass.Grup != null) SelectItem(GrupClassBox, UsedClass.Grup.TypeCar);

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

            if (MachineBrandBox.Tag == null)
            {
                MessageBox.Show("Необходимо укзать Брен (Марка) машины");
                return;
            }
            UsedClass.MachineBrand = MachineBrandBox.Tag as DataBase.GoodsClass.CarBrandClass;

            if (ModificationBox.Tag == null)
            {
                MessageBox.Show("Необходимо укзать модификацию машины");
                return;
            }
            UsedClass.Modification = ModificationBox.Tag as DataBase.GoodsClass.ModificationClass;

            if (GrupClassBox.Tag == null)
            {
                MessageBox.Show("Необходимо укзать группу для этой машины");
                return;
            }
            UsedClass.Grup = GrupClassBox.Tag as DataBase.GoodsClass.GrupClass;

            UsedClass.Update(Program.MainForm.SQLCommander);
            BackForm.Refreh_DataGridViewMain();
            Button_Cancel_Click(null, null);
        }
        private void MachineBrandBox_Enter(object sender, EventArgs e)
        {
            Info.Text = Label3.Text;
            Panel1.Visible = true;
            Selector = 1;
        }
        private void ModificationBox_Enter(object sender, EventArgs e)
        {
            Info.Text = Label9.Text;
            Panel1.Visible = true;
            Selector = 2;
        }
        private void GrupClassBox_Enter(object sender, EventArgs e)
        {
            Info.Text = Label8.Text;
            Panel1.Visible = true;
            Selector = 3;
        }
        private void Сountry_Enter(object sender, EventArgs e) => Panel1.Visible = false;
        private void Comment_Enter(object sender, EventArgs e) => Panel1.Visible = false;
        private void Status_Enter(object sender, EventArgs e) => Panel1.Visible = false;
        private void Price_Enter(object sender, EventArgs e) => Panel1.Visible = false;
        private void MarkupSng_Enter(object sender, EventArgs e) => Panel1.Visible = false;
        private void Сountry_Leave(object sender, EventArgs e) => WorkForm.NormalizationTextBox((TextBox)sender, UsedClass);
        private void Comment_Leave(object sender, EventArgs e) => WorkForm.NormalizationTextBox((TextBox)sender, UsedClass);
        private void Price_Leave(object sender, EventArgs e)
        {
            WorkForm.NormalizationTextBox((TextBox)sender, UsedClass);
            TextBox box = Price;
            try
            {
                decimal q = decimal.Parse(box.Text);
                box = MarkupSng;
                decimal w = decimal.Parse(box.Text);
                SummPrice.Text = ((q * (w / 100)) + q).ToString();
            }
            catch
            {
                box.BackColor = System.Drawing.Color.Honeydew;
                SummPrice.Text = "";
            }
        }
        private void MarkupSng_Leave(object sender, EventArgs e)
        {
            WorkForm.NormalizationTextBox((TextBox)sender, UsedClass);
            TextBox box = MarkupSng;
            try
            {
                decimal q = decimal.Parse(box.Text);
                box = Price;
                decimal w = decimal.Parse(box.Text);
                SummPrice.Text = (((q / 100) * w) + w).ToString();
            }
            catch
            {
                box.BackColor = System.Drawing.Color.Honeydew;
                SummPrice.Text = "";
            }
        }
        private void ADD_button1_Click(object sender, EventArgs e)
        {
            switch (Selector)
            {
                case 1:
                    CarBrand = new frm.FrmCarBrand(new DataBase.GoodsClass.CarBrandClass()) { Tag = this };
                    CarBrand.Show();
                    break;
                case 2:
                    Modification = new FrmModification(new DataBase.GoodsClass.ModificationClass()) { Tag = this };
                    Modification.Show();
                    break;
                default:
                    Grup = new frm.FrmGrup(new DataBase.GoodsClass.GrupClass()) { Tag = this };
                    Grup.Show();
                    break;
            }
            this.Enabled = false;
        }
        private void Del_button3_Click(object sender, EventArgs e)
        {
            object dBParam = Selector switch
            {
                1 => MachineBrandBox.Tag,
                2 => ModificationBox.Tag,
                _ => GrupClassBox.Tag,
            };
            if (dBParam == null) return;
            ((DataBase.ClassDBParam)dBParam).ActiveObjIsDelete = true;
            ((DataBase.ClassDBParam)dBParam).Update(BackForm.SQLCommander);
            Refreh_Combobox();
        }
        private void Edit_button2_Click(object sender, EventArgs e)
        {
            switch (Selector)
            {
                case 1:
                    if (MachineBrandBox.Tag == null) return;
                    CarBrand = new frm.FrmCarBrand(MachineBrandBox.Tag as DataBase.GoodsClass.CarBrandClass) { Tag = this };
                    CarBrand.Show();
                    break;
                case 2:
                    if (ModificationBox.Tag == null) return;
                    Modification = new FrmModification(ModificationBox.Tag as DataBase.GoodsClass.ModificationClass) { Tag = this };
                    Modification.Show();
                    break;
                default:
                    if (GrupClassBox.Tag == null) return;
                    Grup = new frm.FrmGrup(GrupClassBox.Tag as DataBase.GoodsClass.GrupClass) { Tag = this };
                    Grup.Show();
                    break;
            }
            this.Enabled = false;
        }
        private void MachineBrandBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cs = new DataBase.GoodsClass.CarBrandClass();
            var m = (WorkForm.DeliveredClass)MachineBrandBox.SelectedItem;
            if (m == null) return;
            cs.GetDate(m.Id, Program.MainForm.SQLCommander);
            MachineBrandBox.Tag = cs;
        }
        private void ModificationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mc = new DataBase.GoodsClass.ModificationClass();
            var m = (WorkForm.DeliveredClass)ModificationBox.SelectedItem;
            if (m == null) return;
            mc.GetDate(m.Id, Program.MainForm.SQLCommander);
            ModificationBox.Tag = mc;
        }
        private void GrupClassBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var gc = new DataBase.GoodsClass.GrupClass();
            var m = (WorkForm.DeliveredClass)GrupClassBox.SelectedItem;
            if (m == null) return;
            gc.GetDate(m.Id, Program.MainForm.SQLCommander);
            GrupClassBox.Tag = gc;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackForm.Enabled = true;
            BackForm.Select();
        }
    }
}
