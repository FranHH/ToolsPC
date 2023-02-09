using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsPC
{
    public partial class ToolsPC : Form
    {
        #region Declaracion de variables
        private string info = string.Empty;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private int tiempo, hApagado;
        private bool check = false;
        private DateTime hGuardada;
        private AuxMoveMouse mv = null;
        private Thread threadMoveMouse = null;
        #endregion

        #region DLL EXTERN
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        #endregion

        #region Constantes de raton
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        public const int MOUSEEVENTF_LEFTUP = 0x0004;
        public const int MOUSEEVENTF_MOVE = 0x0001;
        #endregion

        #region Inicio de la aplicación

        public ToolsPC()
        {
            InitializeComponent();

            pnlServicios.Visible = false;
            pnlProgApagado.Visible = false;
            pnlMover.Visible = false;

            MessageBox.Show("Para mostrar las utilidades, selecciona la que necesites en Inicio", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.toolTip1.SetToolTip(dtHoraEjecucion, "Hora del local del equipo");
            this.toolTip1.SetToolTip(btnInstalar, "Ruta del servicio para instalar");
            this.toolTip1.SetToolTip(btnDesinstalar, "Nombre del servicio para desinstalar");
            this.toolTip1.SetToolTip(pCuentaAtras, "Tiempo restante de apagado del equipo");
            this.toolTip1.SetToolTip(btnMoverRaton, "Inicia movimiento del ratón");
            this.toolTip1.SetToolTip(btnDetener, "Detiene el movimiento del ratón");


            try
            {
                //Si existe el fichero donde se guarda la hora de apagado programado, lo leo
                if (File.Exists("timer.txt"))
                {
                    WriteShowTimer(null, true);
                }
                else
                {
                    //Creo un evento para la cuenta atrás
                    timer2 = new System.Windows.Forms.Timer();
                    timer2.Tick += new EventHandler(RealTime);
                    timer2.Start();
                    label1.Text = "Selecciona hora";
                }
            }
            catch (Exception) { }
        }

        #endregion

        #region Botones

        private void Aceptar_Click(object sender, EventArgs e)
        {
            VMainTrigger();
        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            VBuildCommand();
        }

        private void btnDesinstalar_Click(object sender, EventArgs e)
        {
            if(!tbNameService.Text.Equals("Nombre del servicio..."))
            {
                VDeleteService(string.IsNullOrEmpty(tbNameService.Text) ? string.Empty : tbNameService.Text);
            }
           
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            vResetValues();
        }

        private void btnMoverRaton_Click(object sender, EventArgs e)
        {
            vStartMoveMouse();
        }

        #endregion

        #region PRINCIPAL
        /// <summary>
        /// Metpodo principal de ejecución
        /// </summary>
        private void VMainTrigger()
        {
            try
            {
                //ProgressBar Inicio 5%
                pbEstado.Value = 5;
                //Calculo el tiempo de ejecucion para la cuenta atras
                hApagado = ConversionHoras(dtHoraEjecucion.Value.Hour, dtHoraEjecucion.Value.Minute, dtHoraEjecucion.Value.Second);
                tiempo = CalcularHora(hApagado);

                //Convierto el tiempo a segundos
                string text = string.Empty;
                string command = string.Empty;
                //ProgressBar 55%
                pbEstado.Value += 35;

                if (rbApagar.Checked)
                {
                    //ProgressBar 65%
                    pbEstado.Value += 10;
                    //Obtengo el comando
                    command = "shutdown -s -t " + tiempo.ToString();

                    //ProgressBar 80%
                    pbEstado.Value += 15;
                    //Muestro el contador
                    pCuentaAtras.Visible = true;
                    //lbMin.Visible = true;
                    //lbHoras.Visible = true;

                    //Creo un evento para la cuenta atrás
                    timer1 = new System.Windows.Forms.Timer();
                    timer1.Tick += new EventHandler(Contador);
                    timer1.Interval = 1000;
                    timer1.Start();
                    //Guardo la hora de apagado junto a la fecha en la que se crea, en un fichero 
                    string datosDeApagado = DateTime.Now.ToString("d") + "\n" + hApagado;
                    WriteShowTimer(datosDeApagado, false);
                    check = true;
                    rbApagar.Checked = false;
                }
                else if (rbCancelarApagado.Checked)
                {
                    command = "shutdown /a";
                    check = true;
                    rbCancelarApagado.Checked = false;
                    //Borro fichero de hora de apagado
                    try
                    {
                        File.Delete("timer.txt");
                        pCuentaAtras.Visible = false;
                        timer2 = new System.Windows.Forms.Timer();
                        timer2.Tick += new EventHandler(RealTime);
                        timer2.Start();
                        label1.Text = "Selecciona hora";
                    }
                    catch (Exception) { }
                }
                else
                {
                    //ProgressBar final 88%
                    pbEstado.Value = 88; 
                    //Muestro mensaje de proceso no finalizado
                    MessageBox.Show("No has seleccionado ninguna opción");
                    //ProgressBar 0%
                    pbEstado.Value = 0;
                }

                //Si todo está correcto, ejecutamos comando
                if (check)
                {
                    //ProgressBar 100%
                    pbEstado.Value += 20;
                    //ProgressBar final 0%
                    pbEstado.Value = 0;
                    if (!bExecuteCommand(command))
                    {
                        MessageBox.Show("Ha ocurrido un problema y no se ha podido relaizar la operación. Por favor, vuelve a intentarlo.");
                    }
                    
                   
                    check = false;
                }


                if (cbReiniciar.Checked)
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
        #endregion

        #region Metodos auxiliares
        /// <summary>
        /// Escribe o muestra el tiempo restante para la ejecución de apagado
        /// </summary>
        /// <param name="tiempo"></param>
        /// <param name="get"></param>
        private void WriteShowTimer(string tiempo, bool get)
        {
            try
            {
                //Si quiero obtener datos, leo el fichero.
                if (get)
                {

                    StreamReader inputFile = new StreamReader("timer.txt");
                    string line = inputFile.ReadLine();


                    //Si el fichero no contiene la fecha de hoy, borro el fichero
                    if (!line.Equals(DateTime.Now.ToString("d")))
                    {
                        inputFile.Close();
                        File.Delete("timer.txt");
                        pCuentaAtras.Visible = false;
                    }
                    else
                    {
                        string time = inputFile.ReadLine();
                        //En caso contrario leo la siguiente linea que contiene la hora de apagado.
                        this.tiempo = CalcularHora(int.Parse(time));

                        int h = (int.Parse(time) / 3600);
                        int m = ((int.Parse(time) - h * 3600) / 60);
                        int s = int.Parse(time) - (h * 3600 + m * 60);
                        string timeShutdown = h.ToString() +":"+ m.ToString() +":"+ s.ToString();
                        dtHoraEjecucion.Value = DateTime.Parse(timeShutdown);
                        //Cierro flujo de salida.
                        inputFile.Close();

                        //Creo un evento para la cuenta atrás
                        timer1 = new System.Windows.Forms.Timer();
                        timer1.Tick += new EventHandler(Contador);
                        timer1.Interval = 1000;
                        timer1.Start();
                        
                        pCuentaAtras.Visible = true;
                        pbEstado.Value = 0;

                    }
                }
                else //En caso contrario, escribo el fichero
                {
                    StreamWriter outputFile = new StreamWriter("timer.txt");

                    outputFile.WriteLine(tiempo);

                    outputFile.Close();
                }
            }
            catch (Exception e) { }
        }

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
                int h = (tiempo / 3600);
                int m = ((tiempo - h * 3600) / 60);
                int s = tiempo - (h * 3600 + m * 60);

                lbHoras.Text = h.ToString() + "h";
                lbMin.Text = m.ToString() + "m";
                lbSeg.Text = s.ToString() + "s";
            }
        }
        private void RealTime(object sender, EventArgs e)
        {
            dtHoraEjecucion.Value = DateTime.Now;
            
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

        /// <summary>
        /// Metodo para construir el comando de instalación de un servicio
        /// </summary>
        private void VBuildCommand()
        {
            string filePath = string.Empty;
            string ruta = @"C:\GIT";

            if (!Directory.Exists(ruta))
            {
                ruta = @"C:\";
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = ruta;
                openFileDialog.Filter = "exe files (*.exe)|*.exe";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                }
            }

            tbRuta.Text = filePath;

            if (filePath != string.Empty)
            {
                if (bExecuteCommand(@"cd " + sGetPathInstallUtil() + "\nInstallUtil.exe " + filePath))
                {
                    MessageBox.Show("Servicio instalado con éxito");
                    tbRuta.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un problema y no se ha instalado el servicio :(");
                }
            }

        }

        /// <summary>
        /// Metodo para eliminar un servicio instalado a traves del nombre de un servicio
        /// </summary>
        /// <param name="nameService"></param>
        private void VDeleteService(string nameService)
        {

            //IList<ServiceController> services = ServiceController.GetServices();
            //ActiveForm.Size = new Size(442, 521);
            //lvServices.Visible = true;

            //foreach(ServiceController item in services)
            //{
            //    lvServices.Items.Add(item.ServiceName);
            //}

            if (!nameService.Equals(string.Empty))
            {
                try
                {
                    //ActiveForm.Size = new Size(442, 383);
                    ServiceController serviceController = new ServiceController(nameService = nameService.Replace(".exe", ""));
                    if (serviceController != null && !string.IsNullOrEmpty(serviceController.Status.ToString()))
                    {
                        if (bExecuteCommand("sc delete " + nameService))
                        {
                            MessageBox.Show("Servicio eliminado con éxito");
                            tbNameService.Text = string.Empty;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se ha encontrado ningun servicio con ese nombre");
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado ningun servicio con ese nombre");
            }
        }

        /// <summary>
        /// Metodo para obtener la ruta de acceso mas actualizada del Framework
        /// </summary>
        /// <returns></returns>
        private string sGetPathInstallUtil()
        {
            string startPath = @"c:\Windows\";
            DirectoryInfo dir = new DirectoryInfo(startPath);
            string commandFinal = string.Empty, name = string.Empty;
            int version = 0, auxVersion = 0, count = 0;

            IList<DirectoryInfo> fileList1 = dir.GetDirectories();

            foreach (DirectoryInfo item in fileList1)
            {
                if (item.Name.ToUpper().ToString().Equals(@"MICROSOFT.NET"))
                {
                    startPath += item.Name.ToString() + @"\";
                    dir = new DirectoryInfo(startPath);

                    IList<DirectoryInfo> fileList2 = dir.GetDirectories();

                    foreach (DirectoryInfo item2 in fileList2)
                    {
                        if (item2.Name.ToUpper().ToString().Equals("FRAMEWORK"))
                        {
                            startPath += item2.Name.ToString() + @"\";
                            dir = new DirectoryInfo(startPath);

                            IList<DirectoryInfo> fileList3 = dir.GetDirectories();

                            foreach (DirectoryInfo item3 in fileList3)
                            {
                                version = item3.Name.ToUpper().Contains("V") ? int.Parse(item3.Name.ToString().Substring(1, 3).Replace(".", "")) : 0;
                                count++;

                                if (version > auxVersion)
                                {
                                    name = item3.Name.ToUpper();
                                    //dir = new DirectoryInfo(startPath);

                                    //IList<FileInfo> fileListFINAL = dir.GetFiles();

                                    //foreach(FileInfo item4 in fileListFINAL)
                                    //{
                                    //    if (item4.Name.ToUpper().Contains("InstallUtil") && item4.Extension.Equals("exe"))
                                    //    {
                                    //        commandFinal = startPath + item4.Name.ToUpper() + item4.Extension.ToUpper();
                                    //    }
                                    //}
                                }
                                else
                                {
                                    auxVersion = version;
                                }

                                if (fileList3.Count == count)
                                {
                                    return startPath += name;
                                }
                            }

                        }
                    }

                }
            }

            return null;
        }

        /// <summary>
        /// Metodo para ejecutar un comando
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        private bool bExecuteCommand(string command)
        {
            try
            {
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
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido iniciar el servicio, comprueba que la ruta al servicio en release sea correcta.");
                return false;
            }
        }

        /// <summary>
        /// Metodo para resetear valores
        /// </summary>
        private void vResetValues()
        {
            try
            {
                if (mv != null)
                {
                    mv.move = false;
                    pbEstado.Value = 0;
                    //threadMoveMouse.Suspend();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al resetear los valores");
            }
        }

        /// <summary>
        /// Metodo para iniciar un nuevo hilo que ejecuta el movimiento del ratón
        /// </summary>
        private void vStartMoveMouse()
        {
            pbEstado.Value = 0;
            MessageBox.Show("Para detener el movimiento del raton, pulsa la tecla de ESC", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Creo nuevo hilo
            mv = new AuxMoveMouse(true);
            threadMoveMouse = new Thread(new ThreadStart(mv.vExecMoveMouse));
            threadMoveMouse.Start();
            Dictionary<string, int> size = mv.getSizeScreen();
            this.Location = new Point(1800,850);
            this.TopMost = true;
            threadMoveMouse.Name = "Movimiento de raton HABILITADO";
            threadMoveMouse.Priority = ThreadPriority.Highest;
            pbEstado.Value = 100;
        }

        #endregion

        #region CB CheckedChanged
        private void cbApagar_CheckedChanged(object sender, EventArgs e)
        {
            hGuardada = dtHoraEjecucion.Value;

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
                dtHoraEjecucion.Enabled = false;
            }
            else
            {
                cbApagar.Enabled = true;
                cbHibernar.Enabled = true;
                cbCerrarSesion.Enabled = true;
                cbCancelarApagado.Enabled = true;
                //dtHoraEjecucion.Value = hGuardada;
                dtHoraEjecucion.Enabled = true;
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
                dtHoraEjecucion.Enabled = false;
            }
            else
            {
                cbReiniciar.Enabled = true;
                cbHibernar.Enabled = true;
                cbApagar.Enabled = true;
                cbCancelarApagado.Enabled = true;
                //dtHoraEjecucion.Value = hGuardada;
                dtHoraEjecucion.Enabled = true;
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
                dtHoraEjecucion.Enabled = false;
            }
            else
            {
                cbReiniciar.Enabled = true;
                cbApagar.Enabled = true;
                cbCerrarSesion.Enabled = true;
                cbCancelarApagado.Enabled = true;
                //dtHoraEjecucion.Value = hGuardada;
                dtHoraEjecucion.Enabled = true;
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
                dtHoraEjecucion.Enabled = false;
            }
            else
            {
                cbApagar.Enabled = true;
                cbReiniciar.Enabled = true;
                cbHibernar.Enabled = true;
                cbCerrarSesion.Enabled = true;
                dtHoraEjecucion.Enabled = true;
                //dtHoraEjecucion.Value = hGuardada;
            }
        }


        private void ToolsPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Escape))
            {
                vResetValues();
            }
        }

        private void tbNameService_Click(object sender, EventArgs e)
        {
            if(tbNameService.Text.Equals("Nombre del servicio..."))
            {
                tbNameService.Text = string.Empty;
                tbNameService.Font = new Font(label1.Font, FontStyle.Regular);
                tbNameService.ForeColor = Color.Black;
            }            
        }

        private void rdBtnPrueba_CheckedChanged(object sender, EventArgs e)
        {
            hGuardada = dtHoraEjecucion.Value;

        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlServicios.Location = new Point(0, 43);
            if (!pnlServicios.Visible)
            {
                pnlServicios.Visible = true;
            }
            pnlProgApagado.Visible = false;
            pnlMover.Visible = false;
            this.Size = new Size(429, 216);
            pbEstado.Size = new Size(412, 15);
        }

        private void programarApagadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlProgApagado.Location = new Point(0, 43);

            if (!pnlProgApagado.Visible)
            {
                pnlProgApagado.Visible = true;
            }
            pnlServicios.Visible = false;
            pnlMover.Visible = false;
            this.Size = new Size(392, 243);
            pbEstado.Size = new Size(376, 15);
        }

        private void moverRatónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMover.Location = new Point(0, 41);

            if (!pnlMover.Visible)
            {
                pnlMover.Visible = true;
            }
            pnlProgApagado.Visible = false;
            pnlServicios.Visible = false;
            this.Size = new Size(120, 161);
            pbEstado.Size = new Size(100, 15);
        }

        private void dtHoraEjecucion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.D0 || e.KeyChar == (char)Keys.D1 || e.KeyChar == (char)Keys.D2 || e.KeyChar == (char)Keys.D3 || e.KeyChar == (char)Keys.D4 || 
                e.KeyChar == (char)Keys.D5 || e.KeyChar == (char)Keys.D6 || e.KeyChar == (char)Keys.D7 || e.KeyChar == (char)Keys.D8 || e.KeyChar == (char)Keys.D9)
            {
                timer2.Stop();
            }            
        }

        #endregion

        #region Clases AUXILIARES
        public class AuxMoveMouse
        {
            #region Declaración de variables
            public bool move = false;
            private static int pos = 0;
            private const int TIMESLEEP = 60;
            #endregion

            #region Constructor
            public AuxMoveMouse(bool move)
            {
                this.move = move;
            }
            #endregion

            #region Ejecucion movimiento raton
            public void vExecMoveMouse()
            {
                do
                {
                    try
                    {

                        ////Obtengo informacion de la pantalla para posicionar el raton 
                        //Dictionary<string, int> ilSizeScreen = getSizeScreen();
                        ////Posiciono el raton en la esquina superior izquierda
                        //mouse_event(MOUSEEVENTF_MOVE, -ilSizeScreen["Ancho"], 0, 0, 0);
                        //mouse_event(MOUSEEVENTF_MOVE, 0, -ilSizeScreen["Alto"], 0, 0);

                        //double lat = (-ilSizeScreen["Alto"] * 180) / (ilSizeScreen["Alto"]) - 90;
                        //double lon = (-ilSizeScreen["Ancho"] * 360) / (ilSizeScreen["Ancho"]) - 180;

                        //pos = 0;

                        //while(pos >= lat)
                        //{
                        //    mouse_event(MOUSEEVENTF_MOVE, 0, 3, 0, 0);
                        //    pos--;
                        //}
                        //pos = 0;

                        //while (pos >= lon)
                        //{
                        //    mouse_event(MOUSEEVENTF_MOVE, 3, 0, 0, 0);
                        //    pos--;
                        //}

                        ////Calculo el centro
                        //int nCentroAltu = ilSizeScreen["Alto"]/2, nCentroAnchu = ilSizeScreen["Ancho"]/2;

                        //mouse_event(MOUSEEVENTF_MOVE, -nCentroAnchu, 0, 0, 0);
                        //mouse_event(MOUSEEVENTF_MOVE, 0, -nCentroAltu, 0, 0);
                        nMoveYNeutro(nMoveYDown(nMoveYUp(nMoveXNeutro(nMoveXLeft(nMoveXRigth(pos))))));
                        pos = 0;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Se ha detenido la aplicacion de forma inesperada");
                    }

                } while (move);
            }
            #endregion

            #region Screen
            public Dictionary<string, int> getSizeScreen()
            {
                Dictionary<string, int> ilScreenDictionary = new Dictionary<string, int>();

                //Determino la cantidad de pantallas disponibles                
                if (Screen.AllScreens.Count() > 1)
                {
                    foreach (Screen item in Screen.AllScreens)
                    {
                        if (item.DeviceName.Equals(Screen.PrimaryScreen.DeviceName))
                        {
                            ilScreenDictionary.Add("Alto", item.Bounds.Height); //X
                            ilScreenDictionary.Add("Ancho", item.Bounds.Width); //Y
                        }
                    }
                }

                return ilScreenDictionary;
            }
            #endregion

            #region Mover 
            public int nMoveXRigth(int pos)
            {
                //Muevo el ratón en su coordenada x hacia la derecha
                do
                {
                    //Compruebo si se ha intentado detener el proceso
                    if (!move)
                    {
                        break;
                    }
                    else
                    {
                        //Muevo el raton 10 px en su coordenada x
                        mouse_event(MOUSEEVENTF_MOVE, 10, 0, 0, 0);
                        //Duermo el proceso 90 ms para dar mejor sensacion de fluidez   
                        Thread.Sleep(TIMESLEEP);
                        //Aumento contador
                        pos += 2;
                    }

                } while (pos <= 74);

                return pos;
            }
            public int nMoveXLeft(int pos)
            {
                //Muevo el ratón en su coordenada x hacia la izquierda
                do
                {
                    //Compruebo si se ha intentado detener el proceso
                    if (!move)
                    {
                        break;
                    }
                    else
                    {
                        //Muevo el raton -10 px en su coordenada x
                        mouse_event(MOUSEEVENTF_MOVE, -10, 0, 0, 0);
                        //Duermo el proceso 90 ms
                        Thread.Sleep(TIMESLEEP);
                        //Disminuyo el contador
                        pos -= 2;
                    }

                } while (pos >= -74);

                return pos;
            }
            public int nMoveXNeutro(int pos)
            {
                //Muevo el ratón en su coordenada x hasta el punto de inicio
                do
                {
                    //Compruebo si se ha intentado detener el proceso
                    if (!move)
                    {
                        break;
                    }
                    else
                    {
                        //Muevo el raton 10 px en su coordenada x
                        mouse_event(MOUSEEVENTF_MOVE, 10, 0, 0, 0);
                        //Duermo el proceso 90 ms   
                        Thread.Sleep(TIMESLEEP);
                        //Aumento contador
                        pos += 2;
                    }

                } while (pos <= 0);

                return pos;
            }
            public int nMoveYUp(int pos)
            {
                //Muevo el ratón en su coordenada Y hacia arriba
                do
                {
                    //Compruebo si se ha intentado detener el proceso
                    if (!move)
                    {
                        break;
                    }
                    else
                    {
                        //Muevo el raton en su coordenada Y
                        mouse_event(MOUSEEVENTF_MOVE, 0, -10, 0, 0);
                        //Duermo el proceso 90 ms
                        Thread.Sleep(TIMESLEEP);
                        //Aumento el contador
                        pos += 2;
                    }

                } while (pos <= 50);

                return pos;
            }
            public int nMoveYDown(int pos)
            {
                //Muevo el ratón en su coordenada Y hacia abajo
                do
                {
                    //Compruebo si se ha intentado detener el proceso
                    if (!move)
                    {
                        break;
                    }
                    else
                    {
                        //Muevo el raton en su coordenada Y
                        mouse_event(MOUSEEVENTF_MOVE, 0, 10, 0, 0);
                        //Duermo el proceso 90 ms
                        Thread.Sleep(TIMESLEEP);
                        //Disminuyo el contador
                        pos -= 2;
                    }

                } while (pos >= -50);

                return pos;
            }
            public int nMoveYNeutro(int pos)
            {
                //Muevo el ratón en su coordenada Y hasta el punto de inicio
                do
                {
                    //Compruebo si se ha intentado detener el proceso
                    if (!move)
                    {
                        break;
                    }
                    else
                    {
                        //Muevo el raton 10 px en su coordenada x
                        mouse_event(MOUSEEVENTF_MOVE, 0, -10, 0, 0);
                        //Duermo el proceso 90 ms 
                        Thread.Sleep(TIMESLEEP);
                        //Aumento contador
                        pos += 2;
                    }

                } while (pos <= 0);

                return pos;
            }
            #endregion
        }

        

        #endregion





    }
}
