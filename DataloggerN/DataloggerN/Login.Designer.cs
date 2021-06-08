namespace DataloggerN
{
    partial class Login
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
            this.btn_ok_ = new MetroFramework.Controls.MetroButton();
            this.combo_personal = new MetroFramework.Controls.MetroComboBox();
            this.cb_password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btn_ok_
            // 
            this.btn_ok_.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_ok_.Location = new System.Drawing.Point(291, 166);
            this.btn_ok_.Name = "btn_ok_";
            this.btn_ok_.Size = new System.Drawing.Size(107, 32);
            this.btn_ok_.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_ok_.TabIndex = 19;
            this.btn_ok_.Text = "Ingresar";
            this.btn_ok_.UseSelectable = true;
            this.btn_ok_.UseStyleColors = true;
            // 
            // combo_personal
            // 
            this.combo_personal.FormattingEnabled = true;
            this.combo_personal.ItemHeight = 23;
            this.combo_personal.Location = new System.Drawing.Point(231, 84);
            this.combo_personal.Name = "combo_personal";
            this.combo_personal.Size = new System.Drawing.Size(236, 29);
            this.combo_personal.TabIndex = 16;
            this.combo_personal.UseSelectable = true;
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
            this.cb_password.Location = new System.Drawing.Point(231, 119);
            this.cb_password.MaxLength = 32767;
            this.cb_password.Name = "cb_password";
            this.cb_password.PasswordChar = '*';
            this.cb_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cb_password.SelectedText = "";
            this.cb_password.SelectionLength = 0;
            this.cb_password.SelectionStart = 0;
            this.cb_password.ShortcutsEnabled = true;
            this.cb_password.Size = new System.Drawing.Size(236, 23);
            this.cb_password.TabIndex = 15;
            this.cb_password.UseSelectable = true;
            this.cb_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cb_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(149, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 25);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Usuario:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(120, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 25);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Contraseña:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 247);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_ok_);
            this.Controls.Add(this.combo_personal);
            this.Controls.Add(this.cb_password);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_ok_;
        private MetroFramework.Controls.MetroComboBox combo_personal;
        private MetroFramework.Controls.MetroTextBox cb_password;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}