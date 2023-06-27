
namespace ExConPram.frm
{
    partial class FrmGrup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.TypeCar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Color_crm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.LightGray;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Cancel.Location = new System.Drawing.Point(760, 211);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(318, 37);
            this.Button_Cancel.TabIndex = 46;
            this.Button_Cancel.Text = "Отмена";
            this.Button_Cancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.BackColor = System.Drawing.Color.LightGray;
            this.Button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_OK.Location = new System.Drawing.Point(760, 168);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(318, 37);
            this.Button_OK.TabIndex = 45;
            this.Button_OK.Text = "OK";
            this.Button_OK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_OK.UseVisualStyleBackColor = false;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // TypeCar
            // 
            this.TypeCar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TypeCar.Location = new System.Drawing.Point(308, 23);
            this.TypeCar.Name = "TypeCar";
            this.TypeCar.Size = new System.Drawing.Size(297, 34);
            this.TypeCar.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 34);
            this.label1.TabIndex = 47;
            this.label1.Text = "Название группы машин";
            // 
            // ID
            // 
            this.ID.AccessibleName = "";
            this.ID.BackColor = System.Drawing.Color.Gainsboro;
            this.ID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(308, 63);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(297, 31);
            this.ID.TabIndex = 50;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(12, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(290, 31);
            this.label12.TabIndex = 49;
            this.label12.Text = "ID карточки";
            // 
            // Color_crm
            // 
            this.Color_crm.BackColor = System.Drawing.Color.LightGray;
            this.Color_crm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Color_crm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Color_crm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Color_crm.FormattingEnabled = true;
            this.Color_crm.Items.AddRange(new object[] {
            "[White] Без метки",
            "[Red] Красный",
            "[Blue] Синий",
            "[LightCoral] Специальный",
            "[Yellow] Желтый"});
            this.Color_crm.Location = new System.Drawing.Point(308, 107);
            this.Color_crm.Name = "Color_crm";
            this.Color_crm.Size = new System.Drawing.Size(297, 31);
            this.Color_crm.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 31);
            this.label4.TabIndex = 51;
            this.label4.Text = "Флажок";
            // 
            // FrmGrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 260);
            this.Controls.Add(this.Color_crm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TypeCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGrup";
            this.Text = "Группа автомобилей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGrup_FormClosing);
            this.Load += new System.EventHandler(this.FrmGrup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.TextBox TypeCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Color_crm;
        private System.Windows.Forms.Label label4;
    }
}