using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsPC
{
    public partial class ToolsPC : Form
    {
        private string info = string.Empty;
        private System.Windows.Forms.Timer timer1;
        private int tiempo;
        private bool check = false;


        public ToolsPC()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Principal();
        }

        private void Principal()
        {
            try
            {
                //ProgressBar Inicio 5%
                pbEstado.Value = 5;
                //Calculo el tiempo de ejecucion para la cuenta atras
                tiempo = CalcularHora(ConversionHoras(dtHoraEjecucion.Value.Hour, dtHoraEjecucion.Value.Minute, dtHoraEjecucion.Value.Second));
                //Convierto el tiempo a segundos
                string text = "Tarea programada correctamente.";
                string command = string.Empty;
                //ProgressBar 55%
                pbEstado.Value += 35;

                if (cbApagar.Checked)
                {
                    //ProgressBar 65%
                    pbEstado.Value += 10;
                    //Obtengo el comando
                    command = "shutdown -s -t " + tiempo.ToString();

                    //ProgressBar 80%
                    pbEstado.Value += 15;
                    //Muestro el contador
                    lbContador.Visible = true;
                    lbSegundos.Visible = true;

                    //Creo un evento para la cuenta atrás
                    timer1 = new System.Windows.Forms.Timer();
                    timer1.Tick += new EventHandler(Contador);
                    timer1.Interval = 1000;
                    timer1.Start();
                    check = true;
                }
                else if (cbReiniciar.Checked)
                {
                    //Reiniciar pc
                    command = "shutdown /r";
                    check = true;
                }
                else if (cbCerrarSesion.Checked)
                {
                    //Cerrar sesion pc
                    command = "shutdown -L";
                    check = true;
                }
                else if (cbHibernar.Checked)
                {
                    //HibernarPC
                    command = "shutdown -h";
                    check = true;
                }
                else
                {
                    //ProgressBar final 88%
                    pbEstado.Value = 88;
                    text = "No has seleccionado ninguna opción";
                    //Muestro mensaje de proceso no finalizado
                    MessageBox.Show(text);
                    //ProgressBar 0%
                    pbEstado.Value = 0;
                }

                //Si todo está correcto, se inicia el proceso
                if (check)
                {
                    this.backgroundWorker1.RunWorkerAsync(2000);
                    //ProgressBar 100%
                    pbEstado.Value += 20;
                    //Muestro mensaje de ejecutado con exito
                    MessageBox.Show(text);
                    //ProgressBar final 0%
                    pbEstado.Value = 0;
                    //Inicio el comando
                    Process cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();
                    cmd.StandardInput.WriteLine(command);
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    //Application.Exit();
                }
            }
            catch (Exception ex)
            {
                //ProgressBar final 88%
                pbEstado.Value = 88;
                //Obtengo el detalle del fallo
                this.info = DateTime.Now.ToString() + " : " + ex.Message.ToString();
                //Muestro mensaje del fallo
                MessageBox.Show("Ha ocurrido un problema --> " + info);
                //ProgressBar 0%
                pbEstado.Value = 0;
            }
        }

        #region Metodos auxiliares
        /// <summary>
        /// Evento para cuenta atrás.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Contador(object sender, EventArgs e)
        {

            if (tiempo == 0)
            {
                timer1.Stop();

            }
            else if (tiempo > 0)
            {
                tiempo--;
                lbContador.Text = tiempo.ToString();
            }
        }

        /// <summary>
        ///  Metodo para calcular la hora exacta de ejecución
        /// </summary>
        /// <param name="segundos"></param>
        /// <returns></returns>
        private int CalcularHora(int segundos)
        {
            //ProgressBar 10%
            pbEstado.Value += 5;
            int tActual = ConversionHoras(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            int resultado = tActual - segundos;

            if (resultado < 0)
            {
                resultado = Math.Abs(resultado);
            }
            

            //ProgressBar 20%
            pbEstado.Value += 10;
            return resultado;
        }

        /// <summary>
        /// Metodo para convertir el tiempo a segundos 
        /// </summary>
        /// <param name="horas"></param>
        /// <param name="minutos"></param>
        /// <param name="segundos"></param>
        /// <returns></returns>
        private int ConversionHoras(int horas, int minutos, int segundos)
        {
          
            int resultado = (horas * 3600) + (minutos * 60) + segundos;
            
            return resultado;
        }
        #endregion

        #region CB CheckedChanged
        private void cbApagar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbApagar.Checked)
            {
                cbReiniciar.Enabled = false;
                cbHibernar.Enabled = false;
                cbCerrarSesion.Enabled = false;
                cbCancelarApagado.Enabled = false;
            }
            else
            {
                cbReiniciar.Enabled = true;
                cbHibernar.Enabled = true;
                cbCerrarSesion.Enabled = true;
                cbCancelarApagado.Enabled = true;
            }
        }

        private void cbReiniciar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReiniciar.Checked)
            {
                cbApagar.Enabled = false;
                cbHibernar.Enabled = false;
                cbCerrarSesion.Enabled = false;
                cbCancelarApagado.Enabled = false;
            }
            else
            {
                cbApagar.Enabled = true;
                cbHibernar.Enabled = true;
                cbCerrarSesion.Enabled = true;
                cbCancelarApagado.Enabled = true;
            }
        }

        private void cbCerrarSesion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCerrarSesion.Checked)
            {
                cbReiniciar.Enabled = false;
                cbHibernar.Enabled = false;
                cbApagar.Enabled = false;
                cbCancelarApagado.Enabled = false;
            }
            else
            {
                cbReiniciar.Enabled = true;
                cbHibernar.Enabled = true;
                cbApagar.Enabled = true;
                cbCancelarApagado.Enabled = true;
            }
        }

        private void cbHibernar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHibernar.Checked)
            {
                cbReiniciar.Enabled = false;
                cbApagar.Enabled = false;
                cbCerrarSesion.Enabled = false;
                cbCancelarApagado.Enabled = false;
            }
            else
            {
                cbReiniciar.Enabled = true;
                cbApagar.Enabled = true;
                cbCerrarSesion.Enabled = true;
                cbCancelarApagado.Enabled = true;
            }
        }

        private void cbCancelarApagado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCancelarApagado.Checked)
            {
                cbApagar.Enabled = false;
                cbReiniciar.Enabled = false;
                cbHibernar.Enabled = false;
                cbCerrarSesion.Enabled = false;
            }
            else
            {
                cbApagar.Enabled = true;
                cbReiniciar.Enabled = true;
                cbHibernar.Enabled = true;
                cbCerrarSesion.Enabled = true;
            }
        }
        #endregion

        #region BackgroundWorker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
       
            BackgroundWorker bw = sender as BackgroundWorker;

            // Extract the argument.
            int arg = (int)e.Argument;

            // Start the time-consuming operation.
            e.Result = TimeConsumingOperation(bw, arg);

            // If the operation was canceled by the user,
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }
        private int TimeConsumingOperation(BackgroundWorker bw, int sleepPeriod)
        {
            int result = 0;

            Random rand = new Random();

            while (!bw.CancellationPending)
            {
                bool exit = false;

                switch (rand.Next(3))
                {
                    // Raise an exception.
                    case 0:
                        {
                            throw new Exception("An error condition occurred.");
                            break;
                        }

                    // Sleep for the number of milliseconds
                    // specified by the sleepPeriod parameter.
                    case 1:
                        {
                            Thread.Sleep(sleepPeriod);
                            break;
                        }

                    // Exit and return normally.
                    case 2:
                        {
                            result = 23;
                            exit = true;
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }

                if (exit)
                {
                    break;
                }
            }

            return result;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // The user canceled the operation.
                MessageBox.Show("Operation was canceled");
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            else
            {
                // The operation completed normally.
                string msg = String.Format("Result = {0}", e.Result);
                MessageBox.Show(msg);
            }
        }
        #endregion

    }
}
