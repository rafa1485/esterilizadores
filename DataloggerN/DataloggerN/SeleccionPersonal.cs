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
    public partial class SeleccionPersonal : MetroFramework.Forms.MetroForm
    {
        SQLiteConnection conexion = new SQLiteConnection(@"Data Source=C:\Users\Eric\Desktop\DataloggerN\datalogger.db");
        SQLiteCommand cmd;
        SQLiteDataAdapter dataAdapter;
        SQLiteCommandBuilder cb;
        int ID = 0;
        public static string persona;

        public SeleccionPersonal()
        {
            InitializeComponent();
            populate();

        }

        public String Texto
        {

	      get { return combo_personal.Text; }

	      set { combo_personal.Text = value; }

	    }

        public Int32 IdPersonal
        {

            get { return ID; }

            set { ID = value; }

        }

        public void populate()
        {
            string script = "SELECT id, apellido || ', ' || nombre as nombrecompleto, password FROM PERSONAL";
            cmd = new SQLiteCommand(script, conexion);
            dataAdapter = new SQLiteDataAdapter(script, conexion);
            cb = new SQLiteCommandBuilder(dataAdapter);
            cmd.Connection = conexion;
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "tabla");
            combo_personal.ValueMember = "id";
            combo_personal.DisplayMember = "nombrecompleto";
            combo_personal.DataSource = ds.Tables["tabla"];            
            
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

        private void btn_ok__Click(object sender, EventArgs e)
        {
           
            string script = "select password from [PERSONAL] where "+ID+"=Id";
            cmd = new SQLiteCommand(script, conexion);
            cmd.Connection = conexion;
             
            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                string cont = cmd.ExecuteScalar().ToString();
                conexion.Close();
                if (cont == cb_password.Text)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Responsable Agregado Correctamente al Ciclo", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "La contraseña es errónea. Intente nuevamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }   
        }

        private void combo_personal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = combo_personal.SelectedIndex + 1;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
