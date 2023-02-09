using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;


namespace MoveMouseService
{
    public partial class MoveMouseService : ServiceBase
    {
        #region Declaracion de variables 
        private Thread __TaskService;
        private object __Mutex;
        private bool m_bStop = true;
        private static int pos = 0;
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

        #region Inicializacion principal
        public MoveMouseService()
        {
            InitializeComponent();
            __Mutex = new object();
        }
        #endregion

        #region OnStart
        public void OnStart()
        {
            OnStart(null);
        }
        
        protected override void OnStart(string[] args)
        {
            try
            {
                //Inicio del servicio
                this.__TaskService = new Thread(new ThreadStart(VExecService));
                this.__TaskService.Start();

                m_bStop = false;
            }
            catch {}
        }
        #endregion

        #region OnStop
        protected override void OnStop()
        {
            lock (__Mutex)
            {
                m_bStop = true;
            }
        }
        #endregion

        #region Ejecucion del servicio
        private void VExecService()
        {
            while (!m_bStop)
            {
                try
                {
                    //Muevo el ratón en su coordenada x hacia la derecha
                    do
                    {
                        //Compruebo si se ha intentado detener el proceso
                        Pressed();
                        //Muevo el raton 10 px en su coordenada x
                        mouse_event(MOUSEEVENTF_MOVE, 10, 0, 0, 0);
                        //Duermo el proceso 80 ms para dar mejor sensacion de fluidez   
                        Thread.Sleep(40);
                        //Aumento contador
                        pos += 2;

                    } while (pos != 100);

                    //Muevo el ratón en su coordenada x hacia la izquierda
                    do
                    {
                        //Compruebo si se ha intentado detener el proceso
                        Pressed();
                        //Muevo el raton -10 px en su coordenada x
                        mouse_event(MOUSEEVENTF_MOVE, -10, 0, 0, 0);
                        //Duermo el proceso 80 ms
                        Thread.Sleep(40);
                        //Disminuyo el contador
                        pos -= 2;

                    } while (pos != -100);

                    //Muevo el ratón en su coordenada x hasta el punto de inicio
                    do
                    {
                        //Compruebo si se ha intentado detener el proceso
                        Pressed();
                        //Muevo el raton 10 px en su coordenada x
                        mouse_event(MOUSEEVENTF_MOVE, 10, 0, 0, 0);
                        //Duermo el proceso 80 ms para dar mejor sensacion de fluidez   
                        Thread.Sleep(40);
                        //Aumento contador
                        pos += 2;

                    } while (pos != 0);

                    //Muevo el ratón en su coordenada Y hacia arriba
                    do
                    {
                        //Compruebo si se ha intentado detener el proceso
                        Pressed();
                        //Muevo el raton en su coordenada Y
                        mouse_event(MOUSEEVENTF_MOVE, 0, -10, 0, 0);
                        //Duermo el proceso
                        Thread.Sleep(40);
                        //Aumento el contador
                        pos += 2;

                    } while (pos != 50);

                    //Muevo el ratón en su coordenada Y hacia abajo
                    do
                    {
                        //Compruebo si se ha intentado detener el proceso
                        Pressed();
                        //Muevo el raton en su coordenada Y
                        mouse_event(MOUSEEVENTF_MOVE, 0, 10, 0, 0);
                        //Duermo el proceso
                        Thread.Sleep(40);
                        //Disminuyo el contador
                        pos -= 2;
                    } while (pos != -50);

                    //Muevo el ratón en su coordenada Y hasta el punto de inicio
                    do
                    {
                        //Compruebo si se ha intentado detener el proceso
                        Pressed();
                        //Muevo el raton 10 px en su coordenada x
                        mouse_event(MOUSEEVENTF_MOVE, 0, -10, 0, 0);
                        //Duermo el proceso 80 ms para dar mejor sensacion de fluidez   
                        Thread.Sleep(40);
                        //Aumento contador
                        pos += 2;

                    } while (pos != 0);
                }
                catch{}
            }
        }
        #endregion

        #region Pressed
        //Metodo para dormir el servicio si se ha pulsado la tecla Shift
        private void Pressed()
        {

            if ((System.Windows.Forms.Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                //Duerme el servicio
                Thread.Sleep(300000);
            }
        }
        #endregion

    }
}
