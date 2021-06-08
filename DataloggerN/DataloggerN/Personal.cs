using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DataloggerN
{
    public partial class Personal : MetroFramework.Forms.MetroForm
    {
        SQLiteConnection conexion = new SQLiteConnection(@"Data Source=C:\Users\Eric\Desktop\DataloggerN\datalogger.db");
        SQLiteCommand cmd;
        SQLiteDataAdapter dataAdapter;
        SQLiteCommandBuilder cb;
        int ID = 0;

        public Personal()
        {
            InitializeComponent();
            populate();
        }
        
        public void populate()
        {

            string script = "SELECT id, nombre, apellido FROM PERSONAL";
            cmd = new SQLiteCommand(script, conexion);
            dataAdapter = new SQLiteDataAdapter(script, conexion);
            cb = new SQLiteCommandBuilder(dataAdapter);
            cmd.Connection = conexion;

            var ds = new DataSet();
            dataAdapter.Fill(ds);
            grid_personal.ReadOnly = true;
            grid_personal.DataSource = ds.Tables[0];

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_save_personal_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_nombre_personal.Text) || String.IsNullOrEmpty(tb_apellido_personal.Text) || String.IsNullOrEmpty(tb_password_personal.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Complete todos los campos", "Alerta",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string script = "insert into [PERSONAL] (nombre, apellido, password) values (@nombre, @apellido, @password)";
                cmd = new SQLiteCommand(script, conexion);
                cmd.Connection = conexion;
                cmd.Parameters.AddWithValue("@nombre", tb_nombre_personal.Text);
                cmd.Parameters.AddWithValue("@apellido", tb_apellido_personal.Text);
                cmd.Parameters.AddWithValue("@password", tb_password_personal.Text);
                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    populate();
                    limpiarCampos();
                    MetroFramework.MetroMessageBox.Show(this, "Se ha ingresado el registro satisfactoriamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void grid_personal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(grid_personal.Rows[e.RowIndex].Cells[0].Value.ToString());
            tb_nombre_personal.Text = grid_personal.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_apellido_personal.Text = grid_personal.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_update_personal_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (String.IsNullOrEmpty(tb_nombre_personal.Text) || String.IsNullOrEmpty(tb_apellido_personal.Text) || String.IsNullOrEmpty(tb_password_personal.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Complete todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string script = "update [PERSONAL] set nombre=@nombre, apellido=@apellido , password=@password where ID=@id";
                    cmd = new SQLiteCommand(script, conexion);
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@nombre", tb_nombre_personal.Text);
                    cmd.Parameters.AddWithValue("@apellido", tb_apellido_personal.Text);
                    cmd.Parameters.AddWithValue("@password", tb_password_personal.Text);
                    try
                    {
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        conexion.Close();
                        populate();
                        limpiarCampos();
                        MetroFramework.MetroMessageBox.Show(this, "Se ha modificado el registro satisfactoriamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Seleccione un registro para modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void limpiarCampos()
        {
            tb_nombre_personal.Clear();
            tb_apellido_personal.Clear();
            tb_password_personal.Clear();
        }

        private void btn_delete_personal_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                string script = "delete from [PERSONAL] where ID=@id";
                cmd = new SQLiteCommand(script, conexion);
                cmd.Connection = conexion;
                cmd.Parameters.AddWithValue("@id", ID);
                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    populate();
                    limpiarCampos();
                    MetroFramework.MetroMessageBox.Show(this, "Se ha eliminado el registro satisfactoriamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Seleccione un registro para eliminar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
