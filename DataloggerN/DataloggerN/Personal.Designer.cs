namespace DataloggerN
{
    partial class Personal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_save_personal = new MetroFramework.Controls.MetroButton();
            this.btn_delete_personal = new MetroFramework.Controls.MetroButton();
            this.btn_update_personal = new MetroFramework.Controls.MetroButton();
            this.grid_personal = new MetroFramework.Controls.MetroGrid();
            this.tb_password_personal = new MetroFramework.Controls.MetroTextBox();
            this.tb_apellido_personal = new MetroFramework.Controls.MetroTextBox();
            this.tb_nombre_personal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_personal)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save_personal
            // 
            this.btn_save_personal.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_save_personal.Location = new System.Drawing.Point(27, 277);
            this.btn_save_personal.Name = "btn_save_personal";
            this.btn_save_personal.Size = new System.Drawing.Size(67, 59);
            this.btn_save_personal.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_save_personal.TabIndex = 1;
            this.btn_save_personal.Text = "Guardar";
            this.btn_save_personal.UseSelectable = true;
            this.btn_save_personal.UseStyleColors = true;
            this.btn_save_personal.Click += new System.EventHandler(this.btn_save_personal_Click);
            // 
            // btn_delete_personal
            // 
            this.btn_delete_personal.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_delete_personal.Location = new System.Drawing.Point(27, 407);
            this.btn_delete_personal.Name = "btn_delete_personal";
            this.btn_delete_personal.Size = new System.Drawing.Size(67, 59);
            this.btn_delete_personal.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_delete_personal.TabIndex = 2;
            this.btn_delete_personal.Text = "Eliminar";
            this.btn_delete_personal.UseSelectable = true;
            this.btn_delete_personal.UseStyleColors = true;
            this.btn_delete_personal.Click += new System.EventHandler(this.btn_delete_personal_Click);
            // 
            // btn_update_personal
            // 
            this.btn_update_personal.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_update_personal.Location = new System.Drawing.Point(27, 342);
            this.btn_update_personal.Name = "btn_update_personal";
            this.btn_update_personal.Size = new System.Drawing.Size(67, 59);
            this.btn_update_personal.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_update_personal.TabIndex = 3;
            this.btn_update_personal.Text = "Modificar";
            this.btn_update_personal.UseSelectable = true;
            this.btn_update_personal.UseStyleColors = true;
            this.btn_update_personal.Click += new System.EventHandler(this.btn_update_personal_Click);
            // 
            // grid_personal
            // 
            this.grid_personal.AllowUserToResizeRows = false;
            this.grid_personal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_personal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_personal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_personal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_personal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_personal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_personal.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_personal.EnableHeadersVisualStyles = false;
            this.grid_personal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_personal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_personal.Location = new System.Drawing.Point(100, 277);
            this.grid_personal.Name = "grid_personal";
            this.grid_personal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_personal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_personal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_personal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_personal.Size = new System.Drawing.Size(433, 189);
            this.grid_personal.Style = MetroFramework.MetroColorStyle.Orange;
            this.grid_personal.TabIndex = 4;
            this.grid_personal.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_personal_RowHeaderMouseClick);
            // 
            // tb_password_personal
            // 
            // 
            // 
            // 
            this.tb_password_personal.CustomButton.Image = null;
            this.tb_password_personal.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.tb_password_personal.CustomButton.Name = "";
            this.tb_password_personal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_password_personal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_password_personal.CustomButton.TabIndex = 1;
            this.tb_password_personal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_password_personal.CustomButton.UseSelectable = true;
            this.tb_password_personal.CustomButton.Visible = false;
            this.tb_password_personal.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_password_personal.Lines = new string[0];
            this.tb_password_personal.Location = new System.Drawing.Point(237, 207);
            this.tb_password_personal.MaxLength = 32767;
            this.tb_password_personal.Name = "tb_password_personal";
            this.tb_password_personal.PasswordChar = '*';
            this.tb_password_personal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_password_personal.SelectedText = "";
            this.tb_password_personal.SelectionLength = 0;
            this.tb_password_personal.SelectionStart = 0;
            this.tb_password_personal.ShortcutsEnabled = true;
            this.tb_password_personal.Size = new System.Drawing.Size(175, 23);
            this.tb_password_personal.TabIndex = 33;
            this.tb_password_personal.UseSelectable = true;
            this.tb_password_personal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_password_personal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_apellido_personal
            // 
            // 
            // 
            // 
            this.tb_apellido_personal.CustomButton.Image = null;
            this.tb_apellido_personal.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.tb_apellido_personal.CustomButton.Name = "";
            this.tb_apellido_personal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_apellido_personal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_apellido_personal.CustomButton.TabIndex = 1;
            this.tb_apellido_personal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_apellido_personal.CustomButton.UseSelectable = true;
            this.tb_apellido_personal.CustomButton.Visible = false;
            this.tb_apellido_personal.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_apellido_personal.Lines = new string[0];
            this.tb_apellido_personal.Location = new System.Drawing.Point(237, 161);
            this.tb_apellido_personal.MaxLength = 32767;
            this.tb_apellido_personal.Name = "tb_apellido_personal";
            this.tb_apellido_personal.PasswordChar = '\0';
            this.tb_apellido_personal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_apellido_personal.SelectedText = "";
            this.tb_apellido_personal.SelectionLength = 0;
            this.tb_apellido_personal.SelectionStart = 0;
            this.tb_apellido_personal.ShortcutsEnabled = true;
            this.tb_apellido_personal.Size = new System.Drawing.Size(175, 23);
            this.tb_apellido_personal.TabIndex = 32;
            this.tb_apellido_personal.UseSelectable = true;
            this.tb_apellido_personal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_apellido_personal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_nombre_personal
            // 
            // 
            // 
            // 
            this.tb_nombre_personal.CustomButton.Image = null;
            this.tb_nombre_personal.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.tb_nombre_personal.CustomButton.Name = "";
            this.tb_nombre_personal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_nombre_personal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_nombre_personal.CustomButton.TabIndex = 1;
            this.tb_nombre_personal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_nombre_personal.CustomButton.UseSelectable = true;
            this.tb_nombre_personal.CustomButton.Visible = false;
            this.tb_nombre_personal.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_nombre_personal.Lines = new string[0];
            this.tb_nombre_personal.Location = new System.Drawing.Point(237, 113);
            this.tb_nombre_personal.MaxLength = 32767;
            this.tb_nombre_personal.Name = "tb_nombre_personal";
            this.tb_nombre_personal.PasswordChar = '\0';
            this.tb_nombre_personal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_nombre_personal.SelectedText = "";
            this.tb_nombre_personal.SelectionLength = 0;
            this.tb_nombre_personal.SelectionStart = 0;
            this.tb_nombre_personal.ShortcutsEnabled = true;
            this.tb_nombre_personal.Size = new System.Drawing.Size(175, 23);
            this.tb_nombre_personal.TabIndex = 31;
            this.tb_nombre_personal.UseSelectable = true;
            this.tb_nombre_personal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_nombre_personal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(126, 205);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(105, 25);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Contraseña:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(149, 159);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 25);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Apellido:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(149, 111);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 25);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Nombre:";
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.Add(this.tb_password_personal);
            this.Controls.Add(this.tb_apellido_personal);
            this.Controls.Add(this.tb_nombre_personal);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.grid_personal);
            this.Controls.Add(this.btn_update_personal);
            this.Controls.Add(this.btn_delete_personal);
            this.Controls.Add(this.btn_save_personal);
            this.Name = "Personal";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Personal";
            ((System.ComponentModel.ISupportInitialize)(this.grid_personal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_save_personal;
        private MetroFramework.Controls.MetroButton btn_delete_personal;
        private MetroFramework.Controls.MetroButton btn_update_personal;
        private MetroFramework.Controls.MetroGrid grid_personal;
        private MetroFramework.Controls.MetroTextBox tb_password_personal;
        private MetroFramework.Controls.MetroTextBox tb_apellido_personal;
        private MetroFramework.Controls.MetroTextBox tb_nombre_personal;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}