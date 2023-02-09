using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MoveMouseService
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        static void Main()
        {
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new MoveMouseService()
            //};
            //ServiceBase.Run(ServicesToRun);

            MoveMouseService mms = new MoveMouseService();
            mms.OnStart();
            while (true)
            {
                System.Threading.Thread.Sleep(20000);
            }
        }
    }
}
