using CapaDatos;

namespace CapaNegocio
{
    public class Negocio

        esto es un commit devrichard
    {
        private CapaDeDatos Obj = new CapaDeDatos();
        public string v1 { get; set; }
        public string t1 { get; set; }

        public string v2 { get; set; }
        public string t2 { get; set; }

        public string v3 { get; set; }
        public string t3 { get; set; }

        public string ListaTipoRequerimiento { get; set; }

        public string ListaTipoRequerimiento2 { get; set; }

        public string ListaPrioridad { get; set; }

        public string ListaPrioridad2 { get; set; }


        //empuje metodo logear
        public bool MetodoLogearUsuario(string Administrador, string contraseña)
        {
            return Obj.Login(Administrador, contraseña);
        }

        //empuje insertar requerimientos
        public void InsertarReq(string TipoRequerimiento,string Userasign, 
            string DescripcionRequerimiento, string Prioridad,int Diasplazo)
        {
            Obj.InsertarDatosABaseDeDatos( TipoRequerimiento, Userasign,
                DescripcionRequerimiento, Prioridad, Diasplazo);
        }
    }   
}
