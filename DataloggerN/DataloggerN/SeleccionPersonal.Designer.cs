namespace DataloggerN
{
    partial class SeleccionPersonal
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btn_ok_ = new MetroFramework.Controls.MetroButton();
            this.cb_password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.combo_personal = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(352, 174);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(107, 32);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "Cancelar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btn_ok_
            // 
            this.btn_ok_.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_ok_.Location = new System.Drawing.Point(223, 174);
            this.btn_ok_.Name = "btn_ok_";
            this.btn_ok_.Size = new System.Drawing.Size(107, 32);
            this.btn_ok_.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_ok_.TabIndex = 13;
            this.btn_ok_.Text = "Aceptar";
            this.btn_ok_.UseSelectable = true;
            this.btn_ok_.UseStyleColors = true;
            this.btn_ok_.Click += new System.EventHandler(this.btn_ok__Click);
            // 
            // cb_password
            // 
            // 
            // 
            // 
            this.cb_password.CustomButton.Image = null;
            this.cb_password.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.cb_password.CustomButton.Name = "";
            this.cb_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cb_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cb_password.CustomButton.TabIndex = 1;
            this.cb_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cb_password.CustomButton.UseSelectable = true;
            this.cb_password.CustomButton.Visible = false;
            this.cb_password.Lines = new string[0];
            this.cb_password.Location = new System.Drawing.Point(223, 122);
            this.cb_password.MaxLength = 32767;
            this.cb_password.Name = "cb_password";
            this.cb_password.PasswordChar = '*';
            this.cb_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cb_password.SelectedText = "";
            this.cb_password.SelectionLength = 0;
            this.cb_password.SelectionStart = 0;
            this.cb_password.ShortcutsEnabled = true;
            this.cb_password.Size = new System.Drawing.Size(236, 23);
            this.cb_password.TabIndex = 9;
            this.cb_password.UseSelectable = true;
            this.cb_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cb_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(112, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 25);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Contraseña:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(135, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 25);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Personal:";
            // 
            // combo_personal
            // 
            this.combo_personal.FormattingEnabled = true;
            this.combo_personal.ItemHeight = 23;
            this.combo_personal.Location = new System.Drawing.Point(223, 87);
            this.combo_personal.Name = "combo_personal";
            this.combo_personal.PromptText = "Seleccionar";
            this.combo_personal.Size = new System.Drawing.Size(236, 29);
            this.combo_personal.TabIndex = 25;
            this.combo_personal.UseSelectable = true;
            this.combo_personal.SelectedIndexChanged += new System.EventHandler(this.combo_personal_SelectedIndexChanged);
            // 
            // SeleccionPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 247);
            this.Controls.Add(this.combo_personal);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btn_ok_);
            this.Controls.Add(this.cb_password);
            this.Name = "SeleccionPersonal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btn_ok_;
        private MetroFramework.Controls.MetroTextBox cb_password;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox combo_personal;
    }
}