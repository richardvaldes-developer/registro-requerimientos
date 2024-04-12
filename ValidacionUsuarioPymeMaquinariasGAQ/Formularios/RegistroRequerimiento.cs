using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Principal
{
    public partial class Formulario2 : Form
    {
        //instancia negocio
        Negocio ClsNegocio = new Negocio();
        private bool Editar = false;


        public Formulario2()
        {
            InitializeComponent();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            ControlTipoRequerimiento();
        }

        //boton salr
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de salir?", "Salir",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        //boton ir a listar requerimiento
        private void button2_Click(object sender, EventArgs e)
        {
            ListarRequerimientos listarRequerimientos = new ListarRequerimientos();
            listarRequerimientos.Show();
        }

        //generador booleano true no se ha ingresado ningun campo
        public bool ValidarDatosIngresados()
        {
            if (CbTipoRequerimiento == null
                && CbUsuarioAsignado == null 
                && TbDescripcionRequerimiento == null 
                && CbTipoRequerimiento == null)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        //listado combobox
        public void ControlTipoRequerimiento()
        {
            Negocio Clsnegocio = new Negocio();

            //combo box tipo requerimiento
            List<Negocio> a = new List<Negocio>();
            a.Add(new Negocio() { v1 = "Base de Datos", t1 = "Base de Datos" });
            a.Add(new Negocio() { v1 = "Sistemas", t1 = "Sistemas" });
            a.Add(new Negocio() { v1 = "Servidores", t1 = "Servidores" });
            CbTipoRequerimiento.DataSource = a;
            CbTipoRequerimiento.DisplayMember = "t1";
            CbTipoRequerimiento.ValueMember = "v1";
            this.Controls.Add(CbTipoRequerimiento);

            //combobox prioridad
            List<Negocio> b = new List<Negocio>();
            b.Add(new Negocio() { v2 = "Baja", t2 = "Baja" });
            b.Add(new Negocio() { v2 = "Media", t2 = "Media" });
            b.Add(new Negocio() { v2 = "Alta", t2 = "Alta" });
            CbPrioridad.DataSource = b;
            CbPrioridad.DisplayMember = "t2";
            CbPrioridad.ValueMember = "v2";
            this.Controls.Add(CbPrioridad);

            //combobox usuarioasignado
            List<Negocio> c = new List<Negocio>();
            c.Add(new Negocio() { v3 = "Pedro", t3 = "Pedro" });
            c.Add(new Negocio() { v3 = "Juan", t3 = "Juan" });
            c.Add(new Negocio() { v3 = "Diego", t3 = "Diego" });
            CbUsuarioAsignado.DataSource = c;
            CbUsuarioAsignado.DisplayMember = "t3";
            CbUsuarioAsignado.ValueMember = "v3";
            this.Controls.Add(CbUsuarioAsignado);
        }


        //recibir la variable del index cbprioridad, convertirlo a numero para 
        //ingresarlo a la BD, prioridad baja 3 dias, prioridad media 4 dias, prioridad alta 5 dias
        // try cach para recibir errores
        //ingresar al insertreq los datos de los combobox, si son de tipo int se debe convertir (convert.tostring())
        private void button4_Click(object sender, EventArgs e)
        {
            if (ValidarDatosIngresados() == false)
            {
                if (Editar == false)
                {
                    try
                    { 
                        int Variable1;
                        Variable1 = Convert.ToInt32(CbPrioridad.SelectedIndex);
                        if (Variable1 == 0)
                        {
                            Variable1 = 3;
                        }
                        else if (Variable1 == 1)
                        {
                            Variable1 = 4;
                        }
                        else if (Variable1 == 2)
                        {
                            Variable1 = 5;
                        }

                        ClsNegocio.InsertarReq(Convert.ToString(CbTipoRequerimiento.SelectedValue),Convert.ToString
                            ( CbUsuarioAsignado.SelectedValue),TbDescripcionRequerimiento.Text,Convert.ToString( CbPrioridad.SelectedValue),Variable1);

                        MessageBox.Show("El requerimiento fue ingresado, el plazo para resolverlo es de  " +Variable1 +" dias"); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo insertar los datos por: " + ex);
                    }
                } 
            }
            else
            {
                MessageBox.Show("debes ingresar todos los campos");
            }
        }

        private void CbUsuarioAsignado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
