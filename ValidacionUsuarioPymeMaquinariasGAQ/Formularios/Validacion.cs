using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;

namespace Principal
{

    public partial class Validacion : Form
    {
        public int contador = 0;


        public Validacion()
        {
            InitializeComponent();
        }
        
        //operacion al presionar boton ingresar usuario
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            /*TextBoxUsuario.Text = "";
            TextBoxContraseña.Text = "";*/
            // si el dato ingresado en texboxusuairio es distinto de iduser (base de datos) mostrara el error porfavor ingresa usuario correcto
            if (TextBoxUsuario.Text != "IDusuario" && TextBoxUsuario.Text != "" )
            {
                //si la contraseña es incorrecta muestra el error contraseña incorrecta
                if (TextBoxContraseña.Text != "contraseña" && TextBoxContraseña.Text != "")
                {

                    Negocio Usuario = new Negocio(); //instancia para utilizar metodo loegar usuario
                    var VariableLoginUsuario = Usuario.MetodoLogearUsuario(TextBoxUsuario.Text, TextBoxContraseña.Text); // le asigno a la variable el metodo que evaluara el login
                    if (VariableLoginUsuario == true)//si la variable retorna un valor true
                    {
                        Credenciales.Text = "";//primero limpio el label en caso de tener algo escrito (usuario o contraseña incorrecta)
                        Formulario2 Form2 = new Formulario2(); // abrir el segundo form
                        Form2.Show();//mostrar formulario 2
                        Form2.FormClosed += SalirFormulario2;//cierro el form2 
                        this.Hide();//oculto el form2 
                    }
                    else
                    {
                        MensajeError("usuario o contraseña incorrecta");// en caso de las credenciales incorrectas muestro un mensaje
                        TextBoxUsuario.Text = "";//limpio la casilla usuario
                        TextBoxContraseña.Text = "";//limpio la casilla contraseña
                    }contador++;// agrego un contador de errores
                    if (contador == 5)// en caso de que sean 4 intentos erroneos, se procede a cerrar la aplicacion(4 intentos)
                    {
                        MessageBox.Show("usuario bloqueado, se cerrara la aplicacion");
                        Application.Exit();
                    }
                        
                }
                else MensajeError("porfavor ingresa tu contraseña");
                TextBoxUsuario.Text = "";//limpio la casilla usuario
                TextBoxContraseña.Text = "";//limpio la casilla contraseña// en caso de que ingrese mal la contraseña muestro un mensaje
            }
            else MensajeError("porfavor ingresa tu usuario");
            TextBoxUsuario.Text = "";//limpio la casilla usuario
            TextBoxContraseña.Text = "";//limpio la casilla contraseña// en caso de que ingrese mal el usuario muestro un mensaje
        }

        private void MensajeError(string Mensaje)
        {
            Credenciales.Text = "    " + Mensaje;
            Credenciales.Visible = true;
        }
       private void SalirFormulario2(object sender, FormClosedEventArgs e)
        {
            TextBoxContraseña.UseSystemPasswordChar = false;
            Credenciales.Visible = false;
            this.Show();
            TextBoxUsuario.Text = ""; //limpio la casilla usuario
            TextBoxContraseña.Text = ""; // limpio la casilla contraseña
        }

        private void Validacion_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Links para contacto
        private void LinkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://github.com/richardvaldes-developer/registro-requerimientos"));
        }

        private void linkLinkeIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("www.linkedin.com/in/richard-valdes-77116225b"));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
