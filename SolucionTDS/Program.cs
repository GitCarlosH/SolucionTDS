using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolucionTDS.EnviarMail;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;



namespace SolucionTDS
{
	static class Program
    {
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]


		static void Main()
		{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Constructor_Clase_Base.FrmEsMayorEdad());

        }


	}
}
