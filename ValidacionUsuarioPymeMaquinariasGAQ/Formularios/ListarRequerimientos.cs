using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaNegocio;

namespace Principal
{
    public partial class ListarRequerimientos : Form
    {
        Negocio ClsNegocio = new Negocio();
        static private string connectionString = "Data Source =DESKTOP-JSOUI5C;Database = ProyectoENE;Trusted_Connection= true";
        private SqlConnection conexion = new SqlConnection(connectionString);
        private bool mostrar = false;


        /*conexion a base de datos directo del form, no logre ejecutar el datagridview con
         conexion desde la capadatos*/
        public SqlConnection abrirConexion()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection cerrarConexion()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }

        public ListarRequerimientos()
        {
            InitializeComponent();
        }

        //creacion de listas combobox 
        public void ControlListaTipoRequerimiento()
        {
            Negocio Clsnegocio = new Negocio();

            //combo box tipo requerimiento
            List<Negocio> c = new List<Negocio>();
            c.Add(new Negocio() { ListaTipoRequerimiento = "base de datos", ListaTipoRequerimiento2 = "base de datos" });
            c.Add(new Negocio() { ListaTipoRequerimiento = "Sistemas", ListaTipoRequerimiento2 = "Sistemas" });
            c.Add(new Negocio() { ListaTipoRequerimiento = "Servidores", ListaTipoRequerimiento2 = "Servidores" });
            comboBoxTipoRequerimiento.DataSource = c;
            comboBoxTipoRequerimiento.DisplayMember = "ListaTipoRequerimiento2";
            comboBoxTipoRequerimiento.ValueMember = "ListaTipoRequerimiento";
            this.Controls.Add(comboBoxTipoRequerimiento);

            //combobox prioridad
            List<Negocio> d = new List<Negocio>();
            d.Add(new Negocio() { ListaPrioridad = "Baja", ListaPrioridad2 = "Baja" });
            d.Add(new Negocio() { ListaPrioridad = "Media", ListaPrioridad2 = "Media" });
            d.Add(new Negocio() { ListaPrioridad = "Alta", ListaPrioridad2 = "Alta" });
            comboBoxPrioridad.DataSource = d;
            comboBoxPrioridad.DisplayMember = "ListaPrioridad2";
            comboBoxPrioridad.ValueMember = "ListaPrioridad";
            this.Controls.Add(comboBoxPrioridad);
        }

        //validar mostrar datos para los combobox, de no estar seleccionado no deja avanzar
        public bool ValidarMostrarDatos()
        {
            if (comboBoxTipoRequerimiento == null
                && comboBoxPrioridad == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
  
        // recibir dato combobox y cruzar con select
        private void ButtonBuscar_Click(object sender, EventArgs e)
        { 
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            abrirConexion();
            string tiporeq = Convert.ToString(comboBoxTipoRequerimiento.SelectedValue);
            string priori = Convert.ToString(comboBoxPrioridad.SelectedValue);
            cerrarConexion();
            if (ValidarMostrarDatos() == false)
            {
                if (mostrar == false)
                {
                    using (var connection = abrirConexion())
                    {
                        string query = "select * from requerimiento where Prioridad ='" + priori + "' And TipoRequerimiento = '" + tiporeq + "'";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                            SqlDataAdapter adapter = new SqlDataAdapter();
                            adapter.SelectCommand = command;
                            DataTable datos = new DataTable();
                            adapter.Fill(datos);
                            dataGridView1.DataSource = datos;
                            connection.Close();
                        }
                    }

                }
            }

        }

        //ejecutar control lista tipo requerimiento
        private void ListarRequerimientos_Load(object sender, EventArgs e)
        {
            ControlListaTipoRequerimiento();
        }

        private void buttonMarcarResuelto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("esta opcion aun no esta habilitada");
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("esta opcion aun no esta habilidada");
        }
    }
}
