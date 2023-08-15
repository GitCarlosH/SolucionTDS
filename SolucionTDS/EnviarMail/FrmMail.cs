using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SolucionTDS.EnviarMail
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        private void DetectarDireccionServidor(out string strDireccionServidor, out int intPuerto)
        {
            /* Cliente SMTP
            * Gmail : smtp.gmail.com puerto:587
            * Hotmail : smtp.live.com puerto:25
            * Yahoo ! : smtp.yahoo.com puerto:587
            * Outlook : smtp-mail.outlook.com puerto:587 */
            switch (cboNombreServidor.Text)
            {
                case "Hotmail":
                    intPuerto = 25;
                    strDireccionServidor = "smtp.live.com"; break;
                case "Yahoo !":
                    intPuerto = 587;
                    strDireccionServidor = "smtp.yahoo.com"; break;
                case "Gmail":
                    intPuerto = 25;
                    strDireccionServidor = "smtp.gmail.com"; break;
                case "Outlook":
                    intPuerto = 587; 
                    strDireccionServidor = "smtp-mail.outlook.com"; break;
                default: throw new Exception("Servidor desconocido");
            }
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MailMessage miMensaje = new MailMessage();
            miMensaje.Subject = txtAsunto.Text;
            miMensaje.To.Add(new MailAddress(txtCorreoDest.Text));
            miMensaje.From = new MailAddress(txtCorreoRem.Text, txtNombre.Text);
            miMensaje.Body = richTextBox1.Text;


            //CorreoElectronico miCorreoElectronico = new CorreoElectronico();
            //miCorreoElectronico.Enviar(miMensaje);



        }
    }
}
