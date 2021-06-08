namespace DataloggerN
{
    partial class Equipos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_equipos = new MetroFramework.Controls.MetroGrid();
            this.btn_modificar_equipo = new MetroFramework.Controls.MetroButton();
            this.btn_eliminar_equipo = new MetroFramework.Controls.MetroButton();
            this.btn_guardar_equipo = new MetroFramework.Controls.MetroButton();
            this.tb_nombre_equipo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_equipos)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_equipos
            // 
            this.grid_equipos.AllowUserToResizeRows = false;
            this.grid_equipos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_equipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_equipos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_equipos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_equipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grid_equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_equipos.DefaultCellStyle = dataGridViewCellStyle11;
            this.grid_equipos.EnableHeadersVisualStyles = false;
            this.grid_equipos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_equipos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_equipos.Location = new System.Drawing.Point(94, 138);
            this.grid_equipos.Name = "grid_equipos";
            this.grid_equipos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_equipos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grid_equipos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_equipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_equipos.Size = new System.Drawing.Size(433, 189);
            this.grid_equipos.Style = MetroFramework.MetroColorStyle.Green;
            this.grid_equipos.TabIndex = 8;
            this.grid_equipos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_equipos_RowHeaderMouseClick);
            // 
            // btn_modificar_equipo
            // 
            this.btn_modificar_equipo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_modificar_equipo.Location = new System.Drawing.Point(21, 203);
            this.btn_modificar_equipo.Name = "btn_modificar_equipo";
            this.btn_modificar_equipo.Size = new System.Drawing.Size(67, 59);
            this.btn_modificar_equipo.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_modificar_equipo.TabIndex = 7;
            this.btn_modificar_equipo.Text = "Modificar";
            this.btn_modificar_equipo.UseSelectable = true;
            this.btn_modificar_equipo.UseStyleColors = true;
            this.btn_modificar_equipo.Click += new System.EventHandler(this.btn_modificar_equipo_Click);
            // 
            // btn_eliminar_equipo
            // 
            this.btn_eliminar_equipo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_eliminar_equipo.Location = new System.Drawing.Point(21, 268);
            this.btn_eliminar_equipo.Name = "btn_eliminar_equipo";
            this.btn_eliminar_equipo.Size = new System.Drawing.Size(67, 59);
            this.btn_eliminar_equipo.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_eliminar_equipo.TabIndex = 6;
            this.btn_eliminar_equipo.Text = "Eliminar";
            this.btn_eliminar_equipo.UseSelectable = true;
            this.btn_eliminar_equipo.UseStyleColors = true;
            this.btn_eliminar_equipo.Click += new System.EventHandler(this.btn_eliminar_equipo_Click);
            // 
            // btn_guardar_equipo
            // 
            this.btn_guardar_equipo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_guardar_equipo.Location = new System.Drawing.Point(21, 138);
            this.btn_guardar_equipo.Name = "btn_guardar_equipo";
            this.btn_guardar_equipo.Size = new System.Drawing.Size(67, 59);
            this.btn_guardar_equipo.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_guardar_equipo.TabIndex = 5;
            this.btn_guardar_equipo.Text = "Agregar";
            this.btn_guardar_equipo.UseSelectable = true;
            this.btn_guardar_equipo.UseStyleColors = true;
            this.btn_guardar_equipo.Click += new System.EventHandler(this.btn_guardar_equipo_Click);
            // 
            // tb_nombre_equipo
            // 
            // 
            // 
            // 
            this.tb_nombre_equipo.CustomButton.Image = null;
            this.tb_nombre_equipo.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.tb_nombre_equipo.CustomButton.Name = "";
            this.tb_nombre_equipo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_nombre_equipo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_nombre_equipo.CustomButton.TabIndex = 1;
            this.tb_nombre_equipo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_nombre_equipo.CustomButton.UseSelectable = true;
            this.tb_nombre_equipo.CustomButton.Visible = false;
            this.tb_nombre_equipo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_nombre_equipo.Lines = new string[0];
            this.tb_nombre_equipo.Location = new System.Drawing.Point(258, 84);
            this.tb_nombre_equipo.MaxLength = 32767;
            this.tb_nombre_equipo.Name = "tb_nombre_equipo";
            this.tb_nombre_equipo.PasswordChar = '\0';
            this.tb_nombre_equipo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_nombre_equipo.SelectedText = "";
            this.tb_nombre_equipo.SelectionLength = 0;
            this.tb_nombre_equipo.SelectionStart = 0;
            this.tb_nombre_equipo.ShortcutsEnabled = true;
            this.tb_nombre_equipo.Size = new System.Drawing.Size(175, 23);
            this.tb_nombre_equipo.TabIndex = 37;
            this.tb_nombre_equipo.UseSelectable = true;
            this.tb_nombre_equipo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_nombre_equipo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(80, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(172, 25);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Nombre del Equipo:";
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 355);
            this.Controls.Add(this.tb_nombre_equipo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.grid_equipos);
            this.Controls.Add(this.btn_modificar_equipo);
            this.Controls.Add(this.btn_eliminar_equipo);
            this.Controls.Add(this.btn_guardar_equipo);
            this.Name = "Equipos";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Equipos";
            ((System.ComponentModel.ISupportInitialize)(this.grid_equipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grid_equipos;
        private MetroFramework.Controls.MetroButton btn_modificar_equipo;
        private MetroFramework.Controls.MetroButton btn_eliminar_equipo;
        private MetroFramework.Controls.MetroButton btn_guardar_equipo;
        private MetroFramework.Controls.MetroTextBox tb_nombre_equipo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}