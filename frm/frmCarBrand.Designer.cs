
namespace ExConPram.frm
{
    partial class FrmCarBrand
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
            this.NameBrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Serial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerationYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBrand
            // 
            this.NameBrand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NameBrand.Location = new System.Drawing.Point(308, 21);
            this.NameBrand.Name = "NameBrand";
            this.NameBrand.Size = new System.Drawing.Size(297, 34);
            this.NameBrand.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // Serial
            // 
            this.Serial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Serial.Location = new System.Drawing.Point(308, 61);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(297, 34);
            this.Serial.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер";
            // 
            // GenerationYear
            // 
            this.GenerationYear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GenerationYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.GenerationYear.Location = new System.Drawing.Point(308, 103);
            this.GenerationYear.Name = "GenerationYear";
            this.GenerationYear.Size = new System.Drawing.Size(297, 34);
            this.GenerationYear.TabIndex = 7;
            this.GenerationYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Год машины";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.LightGray;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Cancel.Location = new System.Drawing.Point(660, 147);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(318, 37);
            this.Button_Cancel.TabIndex = 28;
            this.Button_Cancel.Text = "Отмена";
            this.Button_Cancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.BackColor = System.Drawing.Color.LightGray;
            this.Button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_OK.Location = new System.Drawing.Point(660, 104);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(318, 37);
            this.Button_OK.TabIndex = 27;
            this.Button_OK.Text = "OK";
            this.Button_OK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_OK.UseVisualStyleBackColor = false;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // ID
            // 
            this.ID.AccessibleName = "";
            this.ID.BackColor = System.Drawing.Color.Gainsboro;
            this.ID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(308, 153);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(297, 31);
            this.ID.TabIndex = 30;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(12, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(290, 31);
            this.label12.TabIndex = 29;
            this.label12.Text = "ID карточки";
            // 
            // FrmCarBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 207);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.GenerationYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Serial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBrand);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCarBrand";
            this.Text = "Марка бренд машины";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCarBrand_FormClosing);
            this.Load += new System.EventHandler(this.FrmCarBrand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Serial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GenerationYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label12;
    }
}