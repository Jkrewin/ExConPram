
namespace ExConPram.frm
{
    partial class FrmModification
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
            this.ID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TypeEngine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AirConditioner = new System.Windows.Forms.CheckBox();
            this.DiscBrakes = new System.Windows.Forms.CheckBox();
            this.AutoMusic = new System.Windows.Forms.CheckBox();
            this.Rugs = new System.Windows.Forms.CheckBox();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AccessibleName = "";
            this.ID.BackColor = System.Drawing.Color.Gainsboro;
            this.ID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(308, 65);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(297, 31);
            this.ID.TabIndex = 38;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(12, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(290, 31);
            this.label12.TabIndex = 37;
            this.label12.Text = "ID карточки";
            // 
            // TypeEngine
            // 
            this.TypeEngine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TypeEngine.Location = new System.Drawing.Point(308, 25);
            this.TypeEngine.Name = "TypeEngine";
            this.TypeEngine.Size = new System.Drawing.Size(297, 34);
            this.TypeEngine.TabIndex = 32;
            this.TypeEngine.Leave += new System.EventHandler(this.TypeEngine_Leave);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 34);
            this.label1.TabIndex = 31;
            this.label1.Text = "Тип двигателя";
            // 
            // AirConditioner
            // 
            this.AirConditioner.AutoSize = true;
            this.AirConditioner.Location = new System.Drawing.Point(138, 103);
            this.AirConditioner.Name = "AirConditioner";
            this.AirConditioner.Size = new System.Drawing.Size(163, 32);
            this.AirConditioner.TabIndex = 39;
            this.AirConditioner.Text = "Кондиционер";
            this.AirConditioner.UseVisualStyleBackColor = true;
            // 
            // DiscBrakes
            // 
            this.DiscBrakes.AutoSize = true;
            this.DiscBrakes.Location = new System.Drawing.Point(138, 141);
            this.DiscBrakes.Name = "DiscBrakes";
            this.DiscBrakes.Size = new System.Drawing.Size(208, 32);
            this.DiscBrakes.TabIndex = 40;
            this.DiscBrakes.Text = "Дисковые тормоза";
            this.DiscBrakes.UseVisualStyleBackColor = true;
            // 
            // AutoMusic
            // 
            this.AutoMusic.AutoSize = true;
            this.AutoMusic.Location = new System.Drawing.Point(138, 179);
            this.AutoMusic.Name = "AutoMusic";
            this.AutoMusic.Size = new System.Drawing.Size(150, 32);
            this.AutoMusic.TabIndex = 41;
            this.AutoMusic.Text = "Авто музыка";
            this.AutoMusic.UseVisualStyleBackColor = true;
            // 
            // Rugs
            // 
            this.Rugs.AutoSize = true;
            this.Rugs.Location = new System.Drawing.Point(138, 217);
            this.Rugs.Name = "Rugs";
            this.Rugs.Size = new System.Drawing.Size(183, 32);
            this.Rugs.TabIndex = 42;
            this.Rugs.Text = "Колесные диски";
            this.Rugs.UseVisualStyleBackColor = true;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.LightGray;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Cancel.Location = new System.Drawing.Point(619, 198);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(318, 37);
            this.Button_Cancel.TabIndex = 44;
            this.Button_Cancel.Text = "Отмена";
            this.Button_Cancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.BackColor = System.Drawing.Color.LightGray;
            this.Button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_OK.Location = new System.Drawing.Point(619, 155);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(318, 37);
            this.Button_OK.TabIndex = 43;
            this.Button_OK.Text = "OK";
            this.Button_OK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_OK.UseVisualStyleBackColor = false;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // FrmModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 264);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Rugs);
            this.Controls.Add(this.AutoMusic);
            this.Controls.Add(this.DiscBrakes);
            this.Controls.Add(this.AirConditioner);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TypeEngine);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmModification";
            this.Text = "Комплектация авто";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmModification_FormClosing);
            this.Load += new System.EventHandler(this.FrmModification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TypeEngine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AirConditioner;
        private System.Windows.Forms.CheckBox DiscBrakes;
        private System.Windows.Forms.CheckBox AutoMusic;
        private System.Windows.Forms.CheckBox Rugs;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK;
    }
}