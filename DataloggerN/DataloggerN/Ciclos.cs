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
    public partial class Ciclos : MetroFramework.Forms.MetroForm
    {
        SQLiteConnection conexion = new SQLiteConnection(@"Data Source=C:\Users\Eric\Desktop\DataloggerN\datalogger.db");
        SQLiteCommand cmd;
        SQLiteDataAdapter dataAdapter;
        SQLiteCommandBuilder cb;
        int ID = 0;
        public Ciclos()
        {
            InitializeComponent();
            populate();
        }

        public void populate()
        {

            string script = "SELECT id, numeroCicloDia, fechaHoraInicio, fechaHoraFinal, idEquipo, idTipoCiclo, idResponsableInicio, idResponsableFinal FROM CICLOS";
            cmd = new SQLiteCommand(script, conexion);
            dataAdapter = new SQLiteDataAdapter(script, conexion);
            cb = new SQLiteCommandBuilder(dataAdapter);
            cmd.Connection = conexion;

            var ds = new DataSet();
            dataAdapter.Fill(ds);
            grid_ciclos.ReadOnly = true;
            grid_ciclos.DataSource = ds.Tables[0];

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
    }
}
