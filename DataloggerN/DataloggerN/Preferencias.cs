using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataloggerN.Properties;

namespace DataloggerN
{
    public partial class Preferencias : MetroFramework.Forms.MetroForm
    {
        int valorETO, valorVapor;

        public Preferencias()//decimal d
        {
            InitializeComponent();
            //tbTpoFinCicloVapor.Value = d;
            tbTpoFinCicloVapor.Text = Settings.Default.tbTpoFinCicloVapor.ToString();
            tbTpoFinCicloETO.Text = Settings.Default.tbTpoFinCicloETO.ToString();
        }

        private void mBtnAceptar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbTpoFinCicloVapor.Text, out valorVapor))
            {
                Settings.Default.tbTpoFinCicloVapor = valorVapor;
                this.Close();
            }
            else
            { MessageBox.Show("Solo se admiten Números en esta sección."); }
            
            
        }

        //public decimal cargarvalor()
        //{
            //decimal d = tbTpoFinCicloVapor.Value;
            //return d;
        //}

    }
}
