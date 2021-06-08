using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO.Ports;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Configurations;
using LiveCharts.Defaults;
using LiveCharts.Definitions;
using LiveCharts.Wpf;
using System.Data.SQLite;
using DataloggerN.Properties;

namespace DataloggerN
{
    

    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public float presEq1, presEq2, presEq3, presEq4;
        public float tempEq1, tempEq2, tempEq3, tempEq4;
        public int responsableInicioEquipo1, responsableInicioEquipo2, responsableInicioEquipo3, responsableInicioEquipo4, responsableFinalEquipo1, responsableFinalEquipo2, responsableFinalEquipo3, responsableFinalEquipo4;
        public double doublePEq1, doubleTEq1;
        public int e1 = 0;
        public int e2 = 0;
        public int e3 = 0;
        public int e4 = 0;
        public decimal valor1; // =24
        public int contador = 0;
        public int conInicial = 0;
        int aux = 0;
        public ObservableValue p1, t1;
        public int eq1, eq2, eq3, eq4;
        public long ID_Ciclo_Eq1;
        public long ID_Ciclo_Eq2;
        public long ID_Ciclo_Eq3;
        public long ID_Ciclo_Eq4;

        SerialPort sp = new SerialPort();   
        
        SQLiteConnection conexion = new SQLiteConnection(@"Data Source=C:\Users\Eric\Desktop\DataloggerN\datalogger.db");
        SQLiteCommand cmd;


        public Menu()
        {
            sp.BaudRate = 9600;
            sp.PortName = "COM3";
            sp.Open();
            InitializeComponent();
            tarea();
            GraficoEquipo1();
        }
        
        public async Task tarea()
        {
            while (true)
            {
                reading();
                await Task.Delay(5000);
            }
        }

        private void btn_opciones_Click(object sender, EventArgs e)
        {
            Preferencias pref = new Preferencias(); //valor1
            pref.Show();
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            Personal per = new Personal();
            per.Show();
        }

        private void btn_resp1Eq1_Click(object sender, EventArgs e)
        {
            SeleccionPersonal responsableEq1Ini = new SeleccionPersonal();
            responsableEq1Ini.Texto = "";
            responsableEq1Ini.IdPersonal = 0;
            if (responsableEq1Ini.ShowDialog() == DialogResult.OK)
            {
                label_RespIniCicloEq1.Text = responsableEq1Ini.Texto;
                responsableInicioEquipo1 = responsableEq1Ini.IdPersonal;
            }
        }

        private void btn_resp2Eq1_Click(object sender, EventArgs e)
        {
            SeleccionPersonal responsableEq1Fin = new SeleccionPersonal();
            responsableEq1Fin.Texto = "";
            responsableEq1Fin.IdPersonal = 0;
            if (responsableEq1Fin.ShowDialog() == DialogResult.OK)
            {
                label_RespFinCicloEq1.Text = responsableEq1Fin.Texto;
                responsableFinalEquipo1 = responsableEq1Fin.IdPersonal;
            }
        }

        private void btn_resp1Eq2_Click(object sender, EventArgs e)
        {
            SeleccionPersonal responsableEq2Ini = new SeleccionPersonal();
            responsableEq2Ini.Texto = "";
            responsableEq2Ini.IdPersonal = 0;
            if (responsableEq2Ini.ShowDialog() == DialogResult.OK)
            {
                label_RespIniCicloEq2.Text = responsableEq2Ini.Texto;
                responsableInicioEquipo2 = responsableEq2Ini.IdPersonal;
            }
        }

        private void btn_resp2Eq2_Click(object sender, EventArgs e)
        {
            SeleccionPersonal responsableEq2Fin = new SeleccionPersonal();
            responsableEq2Fin.Texto = "";
            responsableEq2Fin.IdPersonal = 0;
            if (responsableEq2Fin.ShowDialog() == DialogResult.OK)
            {
                label_RespFinCicloEq2.Text = responsableEq2Fin.Texto;
                responsableFinalEquipo2 = responsableEq2Fin.IdPersonal;
            }
        }

        private void btn_resp1Eq3_Click(object sender, EventArgs e)
        {
            SeleccionPersonal responsableEq3Ini = new SeleccionPersonal();
            responsableEq3Ini.Texto = "";
            responsableEq3Ini.IdPersonal = 0;
            if (responsableEq3Ini.ShowDialog() == DialogResult.OK)
            {
                label_RespIniCicloEq3.Text = responsableEq3Ini.Texto;
                responsableInicioEquipo3 = responsableEq3Ini.IdPersonal;
            }
        }

        private void btn_resp2Eq3_Click(object sender, EventArgs e)
        {
            SeleccionPersonal responsableEq3Fin = new SeleccionPersonal();
            responsableEq3Fin.Texto = "";
            responsableEq3Fin.IdPersonal = 0;
            if (responsableEq3Fin.ShowDialog() == DialogResult.OK)
            {
                label_RespFinCicloEq3.Text = responsableEq3Fin.Texto;
                responsableFinalEquipo3 = responsableEq3Fin.IdPersonal;
            }
        }

        private void btn_resp1Eq4_Click(object sender, EventArgs e)
        {
            SeleccionPersonal responsableEq4Ini = new SeleccionPersonal();
            responsableEq4Ini.Texto = "";
            responsableEq4Ini.IdPersonal = 0;
            if (responsableEq4Ini.ShowDialog() == DialogResult.OK)
            {
                label_RespIniCicloEq4.Text = responsableEq4Ini.Texto;
                responsableInicioEquipo4 = responsableEq4Ini.IdPersonal;
            }
        }

        private void btn_resp2Eq4_Click(object sender, EventArgs e)
        {
            SeleccionPersonal responsableEq4Fin = new SeleccionPersonal();
            responsableEq4Fin.Texto = "";
            responsableEq4Fin.IdPersonal = 0;
            if (responsableEq4Fin.ShowDialog() == DialogResult.OK)
            {
                label_RespFinCicloEq4.Text = responsableEq4Fin.Texto;
                responsableFinalEquipo4 = responsableEq4Fin.IdPersonal;
            }
        }
        
        private void btn_equipos_Click(object sender, EventArgs e)
        {
            Equipos equipo = new Equipos();
            equipo.Show();
        }

        private void btn_ciclos_Click(object sender, EventArgs e)
        {
            Ciclos ciclos = new Ciclos();
            ciclos.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "\nResponsable 1 indica el personal responsable por el inicio del ciclo de dicho equipo. \nResponsable 2 indica el presonal responsable por el fin del ciclo de dicho equipo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_tipo_ciclos_Click(object sender, EventArgs e)
        {
            TipoCiclo tipoCiclo = new TipoCiclo();
            tipoCiclo.Show();            
        }

        public async Task ingresoData()
        {
            while (true)
            {
                 await Task.Delay(5000);
            }
        }

        public async Task reading() //Tarea de barrido en las presiones (tambien lee las temperaturas)
        {
            contador = contador + 1;
            //label1.Text = "Contador: " + contador.ToString() + "- Aux: " + aux.ToString() + "- ConInicial: " + conInicial.ToString();

            if (e1 == 0 && e2 == 0 && e3 == 0 && e4 == 0 )
            {
                contador = 0;
            }

            sp.Write("0");
            string pin0 = sp.ReadLine();
            presEq1 = float.Parse(pin0, CultureInfo.InvariantCulture.NumberFormat);
            eq1Label.Text = presEq1.ToString();
            decimal decimalPEq1 = Convert.ToDecimal(presEq1);
            doublePEq1 = Convert.ToDouble(decimalPEq1);

            await Task.Delay(100);

            sp.Write("1");
            string pin1 = sp.ReadLine();
            tempEq1 = float.Parse(pin1, CultureInfo.InvariantCulture.NumberFormat);
            decimal decimalTEq1 = Convert.ToDecimal(tempEq1);
            doubleTEq1 = Convert.ToDouble(decimalTEq1);

            if (presEq1 > 1.3 || e1 == 1)
            {
                e1 = 1;                 
                funcionEq1();                
            }
            await Task.Delay(200);
            

            sp.Write("2");
            string pin2 = sp.ReadLine();
            presEq2 = float.Parse(pin2, CultureInfo.InvariantCulture.NumberFormat);
            //eq2Label.Text = presEq2.ToString();

            await Task.Delay(100);

            sp.Write("3");
            string pin3 = sp.ReadLine();
            tempEq2 = float.Parse(pin3, CultureInfo.InvariantCulture.NumberFormat);

            if (presEq2 > 1.3 || e2 == 1)
            {
                e2 = 1;
                funcionEq2();
                //eq2Label.Text = "El equipo está recolectando datos";
            }

            await Task.Delay(200);


            sp.Write("4");
            string pin4 = sp.ReadLine();
            presEq3 = float.Parse(pin4, CultureInfo.InvariantCulture.NumberFormat);
            //eq3Label.Text = presEq3.ToString();

            await Task.Delay(100);

            sp.Write("5");
            string pin5 = sp.ReadLine();
            tempEq3 = float.Parse(pin5, CultureInfo.InvariantCulture.NumberFormat);

            if (e3 == 0)
            {
                if (presEq3 > 1.3 || e3 == 1)
                {
                    e3 = 1;
                    //funcionEq3();
                    //eq3Label.Text = "El equipo está recolectando datos";
                }
                
                await Task.Delay(200);
            }



            sp.Write("6");
            string pin6 = sp.ReadLine();
            presEq4 = float.Parse(pin6, CultureInfo.InvariantCulture.NumberFormat);
            //eq4Label.Text = presEq4.ToString();

            await Task.Delay(100);

            sp.Write("7");
            string pin7 = sp.ReadLine();
            tempEq4 = float.Parse(pin7, CultureInfo.InvariantCulture.NumberFormat);

            if (e4 == 0)
            {
                if (presEq4 > 40)
                {
                    e4 = 1;
                    //eq4Label.Text = "La presion supera los 40 BAR";
                    //eq4Label.ForeColor = System.Drawing.Color.Red;
                }

                await Task.Delay(200);
            }
            else { //eq4Label.Text = "El equipo está recolectando datos"; 
            }
        }

        public void funcionEq1()
        { 
            cartesianChart1.Show();
            //eq1Label.Text = "El equipo está recolectando datos P: " + presEq1 + "- T: " + tempEq1;            
            dibujarGrafico();
            if (eq1 == 0)
            {
                crearCicloEq1();                
            }
                  
            if (presEq1 < 1.2 && presEq1 > 0.8)
            {
                if (aux == 0)
                {
                    conInicial = contador;
                }
                aux = contador - conInicial + 1;                
            }
            else
            {aux = 0;}

            if (aux == Settings.Default.tbTpoFinCicloVapor)
            {
                e1 = 0;
                limpiarGraficoEquipo1();
                cartesianChart1.Hide();                
                finalizarCicloEq1();
                aux = 0;
                eq1 = 0;
            }
            
            else
            {
                insertarDatosEq1();
            };
        }

        public void funcionEq2()
        {
            //eq2Label.Text = "La presion supera los 1.3 BAR";
            //eq2Label.ForeColor = System.Drawing.Color.Red;
            panel2.BackColor = Color.Indigo;
            if (presEq2 < 1.3)
            {
                e2 = 0;
                panel2.BackColor = Color.White;
            }         
        }

        public void funcionEq3()
        {
            //eq3Label.Text = "La presion supera los 1.3 BAR";
            //eq3Label.ForeColor = System.Drawing.Color.Red;
            panel3.BackColor = Color.Indigo;
            
            if (presEq3 < 1.3)
            {
                e3 = 0;
                panel3.BackColor = Color.White;
            }
            
        }

        public void insertarDatosEq1()
        {
           
            string script = "insert into [DATOS] (temperatura, presion, tiempo, idCiclo) values (@temp, @pres, @tiempo, @idCiclo)";
            cmd = new SQLiteCommand(script, conexion);
            cmd.Connection = conexion;
            cmd.Parameters.AddWithValue("@temp", tempEq1);
            cmd.Parameters.AddWithValue("@pres", presEq1);
            cmd.Parameters.AddWithValue("@tiempo", DateTime.Now);
            cmd.Parameters.AddWithValue("@idCiclo", ID_Ciclo_Eq1);

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void extraerUltimoDatoEq1()
        {

            string script = "select * from [DATOS] where equipo = 1 and id = (select MAX(id) from DATOS) ";
            SQLiteCommand cmd = new SQLiteCommand(script, conexion);
            cmd.Connection = conexion;

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

        public void dibujarGrafico()
        {
            p1.Value = doublePEq1;
            t1.Value = doubleTEq1;
            cartesianChart1.Series[0].Values.Add(p1.Value);
            cartesianChart1.Series[1].Values.Add(t1.Value);
        }

        public void crearCicloEq1()
        {
            string script = "insert into [CICLOS] (fechaHoraInicio, idEquipo) values (@inicio, @IdEquipo)";
            cmd = new SQLiteCommand(script, conexion);
            cmd.Connection = conexion;
            cmd.Parameters.AddWithValue("@inicio", DateTime.Now);
            cmd.Parameters.AddWithValue("@IdEquipo", 1);
            label1.Text = ID_Ciclo_Eq1.ToString();

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                ID_Ciclo_Eq1 = conexion.LastInsertRowId;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            eq1 = 1;
            
        }

        public void finalizarCicloEq1()
        {
            string query = "update [CICLOS] set fechaHoraFinal=@fechaFinal, idResponsableInicio=@idRInicio, idResponsableFinal=@idRFinal where ID=@id";
            cmd = new SQLiteCommand(query, conexion);
            cmd.Connection = conexion;
            cmd.Parameters.AddWithValue("@id", ID_Ciclo_Eq1);
            cmd.Parameters.AddWithValue("@fechaFinal", DateTime.Now);
            cmd.Parameters.AddWithValue("@idRInicio", responsableInicioEquipo1);
            cmd.Parameters.AddWithValue("@idRFinal", responsableFinalEquipo1);
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
            limpiarResponsablesEquipo1();
            
        }

        public void GraficoEquipo1()
        {
            p1 = new ObservableValue(0);
            t1 = new ObservableValue(0);
            cartesianChart1.Hide();
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Presión",
                    Values = new ChartValues<double>(),
                    ScalesYAt = 1,
                    Fill = System.Windows.Media.Brushes.Transparent
                },

                new LineSeries
                {
                    Title = "Temperatura",
                    Values = new ChartValues<double>(),
                    ScalesYAt = 0,
                    Fill = System.Windows.Media.Brushes.Transparent
                },
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Tiempo(m)",
                LabelFormatter = value => new DateTime((long)value).ToString("mm:ss"),
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Presión",
                Position = AxisPosition.RightTop
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Temperatura",
                Position = AxisPosition.RightTop
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;

        }

        public void limpiarGraficoEquipo1()
        {
            cartesianChart1.Series[0].Values.Clear();
            cartesianChart1.Series[1].Values.Clear();
        }

        public void limpiarResponsablesEquipo1()
        {
            responsableInicioEquipo1 = 0;
            responsableFinalEquipo1 = 0;
            label_RespIniCicloEq1.Text = "";
            label_RespFinCicloEq1.Text = "";
        }

    }
}
