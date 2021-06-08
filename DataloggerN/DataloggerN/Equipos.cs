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
    public partial class Equipos : MetroFramework.Forms.MetroForm
    {
        SQLiteConnection conexion = new SQLiteConnection(@"Data Source=C:\Users\Eric\Desktop\DataloggerN\datalogger.db");
        SQLiteCommand cmd;
        SQLiteDataAdapter dataAdapter;
        SQLiteCommandBuilder cb;
        int ID = 0;

        public Equipos()
        {
            InitializeComponent();
            populate();
        }

        public void populate()
        {

            string script = "SELECT id, nombre FROM EQUIPOS";
            cmd = new SQLiteCommand(script, conexion);
            dataAdapter = new SQLiteDataAdapter(script, conexion);
            cb = new SQLiteCommandBuilder(dataAdapter);
            cmd.Connection = conexion;

            var ds = new DataSet();
            dataAdapter.Fill(ds);
            grid_equipos.ReadOnly = true;
            grid_equipos.DataSource = ds.Tables[0];

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

        private void grid_equipos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(grid_equipos.Rows[e.RowIndex].Cells[0].Value.ToString());
            tb_nombre_equipo.Text = grid_equipos.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_guardar_equipo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_nombre_equipo.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "El campo debe ser completado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string script = "insert into [EQUIPOS] (nombre) values (@nombre)";
                cmd = new SQLiteCommand(script, conexion);
                cmd.Connection = conexion;
                cmd.Parameters.AddWithValue("@nombre", tb_nombre_equipo.Text);
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

        private void btn_modificar_equipo_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (String.IsNullOrEmpty(tb_nombre_equipo.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "El campo debe ser completado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string script = "update [EQUIPOS] set nombre=@nombre where ID=@id";
                    cmd = new SQLiteCommand(script, conexion);
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@nombre", tb_nombre_equipo.Text);
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

        private void btn_eliminar_equipo_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                string script = "delete from [EQUIPOS] where ID=@id";
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

        private void limpiarCampos()
        {
            tb_nombre_equipo.Clear();
        }
    }
}
