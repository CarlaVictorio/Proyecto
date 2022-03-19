using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace cliente
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }
        private void entrar_Click(object sender, EventArgs e)
        {


        }

        private void enviar_Click(object sender, EventArgs e)
        {
            //En la versión inicial usaremos este botón para empezar la conexión
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.101");
            IPEndPoint ipep = new IPEndPoint(direc, 9050);

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;

                //En esta versión sólo veremos si es capaz de conectarse o no
                if (partidas_ganadas.Checked)
                {
                    
                }
                else if (tablones.Checked)
                {
                    
                }
                else if (id_usuario.Checked)
                {

                }
                else
                    MessageBox.Show("Escoge una de las opciones para poder enviar tu consulta.");

                // Se terminó el servicio. 
                // Nos desconectamos
                server.Shutdown(SocketShutdown.Both);
                server.Close();
            }
            catch (SocketException)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

        }

       
    }
}
